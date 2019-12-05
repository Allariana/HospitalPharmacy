using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalPharmacy
{
    class ConnectionManager
    {
        public SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Pharmacy;Integrated Security=True");

        private static ConnectionManager instance; //singleton

        private ConnectionManager() { } //żeby żadna inna klasa nie mogła go stworzyć

        public static ConnectionManager getInstance()
        {
            if (instance == null)
            {
                instance = new ConnectionManager();
            }
            return instance;
        }
        
        public bool verifyIfUserIsCorrect(String username, String password)
        {
            connection.Open();
            String command = "select * from Users where Username = '"
                + username + "' AND Password = '" + password + "';";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            bool result = false;
            foreach (DataRow r in dt.Rows)
            {
                result = true;
            }
            connection.Close();
            return result;
        }    
        public void getColumn(String tablename,String columnname, DataTable dataTable)
        {
            connection.Open();
            dataTable.Clear();
            String command = "select " + columnname + " from " + tablename + ";";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(dataTable);
            connection.Close();
        }       
        public String getRecord(String columnname, int id)
        {
            connection.Open();
            DataTable valueTable = new DataTable();
            String value;
            SqlCommand getValue = new SqlCommand("select " + columnname + " from ProfileView where UserID = " + id + ";", connection);
            SqlDataReader reader = getValue.ExecuteReader();
            valueTable.Load(reader);
            DataRow dw = valueTable.Rows[0];
            value = dw[0].ToString();
            connection.Close();
            return value;
        }
        public void getMedicinesOrderDetails(DataTable dataTable, String MedicineOrderID)
        {
            connection.Open();
            int id = int.Parse(MedicineOrderID.ToString());
            String command = "select m.TradeName, m.ActiveSubstance, m.[Dose(mg)], m.QuantityPerUnit, s.CompanyName, d.Amount, d.Price " +
                "from MedicineOrderDetails d join Medicines m on d.MedicineID = m.MedicineID join Suppliers s on s.SupplierID = m.SupplierID join MedicinesOrders o" +
                "    on o.MedicinesOrderID = d.MedicinesOrderID and o.MedicinesOrderID = " + id + ";";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(dataTable);
            connection.Close();
        }
        public void getOrderDetails(DataTable dataTable, String MedicineOrderID)
        {
            connection.Open();
            int id = int.Parse(MedicineOrderID.ToString());
            String command = "select m.TradeName, m.ActiveSubstance, m.[Dose(mg)], m.QuantityPerUnit, s.CompanyName, d.Amount " +
                "from OrderDetails d join Medicines m on d.MedicineID = m.MedicineID join Suppliers s on s.SupplierID = m.SupplierID join Orders o " +
                "on o.OrderID = d.OrderID and o.OrderID = " + id + ";";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(dataTable);
            connection.Close();
        }
        public void getPackage(DataTable dataTable, String medicineID)
        {
            connection.Open();
            int id = int.Parse(medicineID.ToString());
            String command = "select [SerialNumber(SN)],[TermofValidity(EXP)],[SerialNumber(LOT)] from PackageofMedicine where OrderDetailID is null and MedicineID =" + id + ";";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(dataTable);
            connection.Close();
        }
        public void pickUpOrder(String MedicineOrderID)
        {
            int id = int.Parse(MedicineOrderID.ToString());
            try
            {
                connection.Open();

                String pickUpOrderCommand = "UPDATE MedicinesOrders SET RealizationFlag = 'Y', RealizationDate = CONVERT (date, SYSDATETIME()) " +
                "where MedicinesOrderID = " + id + "; " +
                " UPDATE Medicines SET UnitsInStock = UnitsInStock + " +
                "(select a.Amount from(select d.MedicineID MedicineID, d.Amount Amount from MedicineOrderDetails d join Medicines m on m.MedicineID = d.MedicineID " +
                "join MedicinesOrders o on d.MedicinesOrderID = o.MedicinesOrderID and o.MedicinesOrderID = " + id + ")a join Medicines m on a.MedicineID = m.MedicineID " +
                "and a.MedicineID = Medicines.MedicineID)where MedicineID in (select d.MedicineID from MedicineOrderDetails d join MedicinesOrders o on " +
                "d.MedicinesOrderID = o.MedicinesOrderID and d.MedicinesOrderID = " + id + "); " +
                "INSERT INTO PackageofMedicine ([SerialNumber(SN)],[MedicineID],[TermofValidity(EXP)],[SerialNumber(LOT)],[Price(EUR)],[MedicineOrderDetailsID])" +
                    "SELECT a.[SerialNumber(SN)],RIGHT(a.[SerialNumber(SN)],3),CONVERT(DATE,a.[TermOfValidity(EXP)]),a.[SerialNumber(LOT)], CONVERT(FLOAT,a.[Price(EUR)]), d.MedicineOrderDetailsID " +
                    "FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0','Excel 12.0;Database=D:\\Kinga\\Studies\\IV rok\\Semestr 7\\Praca dyplomowa\\Invoices\\" +
                    MedicineOrderID + ".xlsx','SELECT * from [Arkusz1$]')a join MedicineOrderDetails d on RIGHT(a.[SerialNumber(SN)],3)= d.MedicineID " +
                    "join MedicinesOrders o on o.MedicinesOrderID = d.MedicinesOrderID and d.MedicinesOrderID = " + id + ";" +
                    "UPDATE MedicineOrderDetails SET Price = s.sumPRICE from (select SUM([Price(EUR)]) as sumPrice from PackageOfMedicine p where " +
                    "p.MedicineOrderDetailsID = MedicineOrderDetailsID) s where MedicinesOrderID = " + id + "; " +
                    "UPDATE MedicinesOrders SET Price = s.sumPRICE from (select SUM(Price) as sumPrice from MedicineOrderDetails d " +
                    "where d.MedicinesOrderID = MedicinesOrderID)s where MedicinesOrderID = " + id + ";";
                 new SqlCommand(pickUpOrderCommand, connection).ExecuteNonQuery();
                 MessageBox.Show("Succeed!");
            }
            catch (Exception ex)
            {
                
                String pickUpOrderCommand = "UPDATE MedicinesOrders SET RealizationFlag = 'N', RealizationDate = null where MedicinesOrderID " +
                    "= " + id + "; ";
                new SqlCommand(pickUpOrderCommand, connection).ExecuteNonQuery();
                MessageBox.Show(ex.Message);
                
            }
            finally {
                connection.Close();
            }
            
        }
        public void completeOrder(String OrderID, int pharmacistID)
        {
            int id = int.Parse(OrderID.ToString());
            connection.Open();
                try
            {
                
                SqlCommand checkIfEnoughMedicines = new SqlCommand("select TOP (1) Units from (select UnitsInStock - (select a.Amount from(select d.MedicineID MedicineID, " +
                    "d.Amount Amount from OrderDetails d join Medicines m on m.MedicineID = d.MedicineID join Orders o on d.OrderID = o.OrderID and o.OrderID = " + id + ")a " +
                    "join Medicines m on a.MedicineID = m.MedicineID and a.MedicineID = Medicines.MedicineID) Units from Medicines where MedicineID in " +
                    "(select d.MedicineID from OrderDetails d join Orders o on d.OrderID = o.OrderID and d.OrderID = " + id + "))b where Units < 0; ", connection);
                         
                SqlDataReader reader2 = checkIfEnoughMedicines.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader2);
                reader2.Close();
               
                    if (dataTable.Rows.Count == 0)
                    {
                        String completeOrderCommand = "UPDATE Orders SET RealizationFlag = 'Y', RealizationDate = CONVERT (date, SYSDATETIME()), UserID = " + pharmacistID
                        + " where OrderID = " + id + ";" +
                        " UPDATE Medicines SET UnitsInStock = UnitsInStock - " +
                        "(select a.Amount from(select d.MedicineID MedicineID, d.Amount Amount from OrderDetails d join Medicines m on m.MedicineID = d.MedicineID " +
                        "join Orders o on d.OrderID = o.OrderID and o.OrderID = " + id + ")a join Medicines m on a.MedicineID = m.MedicineID " +
                        "and a.MedicineID = Medicines.MedicineID)where MedicineID in (select d.MedicineID from OrderDetails d join Orders o on " +
                        "d.OrderID = o.OrderID and d.OrderID = " + id + "); ";
                        new SqlCommand(completeOrderCommand, connection).ExecuteNonQuery();
                    SqlCommand getOrderDetailsID = new SqlCommand("select OrderDetailID from OrderDetails where OrderID=" + id + ";", connection);
                    SqlDataReader idReader = getOrderDetailsID.ExecuteReader();
                    DataTable data = new DataTable();
                    data.Load(idReader);
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        String updatePackage = "UPDATE PackageOfMedicine SET OrderDetailID = " + int.Parse(data.Rows[i].ItemArray[0].ToString()) +
                        "where[SerialNumber(SN)] in (select TOP(select Amount from OrderDetails where OrderDetailID = " + int.Parse(data.Rows[i].ItemArray[0].ToString()) +
                        ")[SerialNumber(SN)] from PackageOfMedicine p join OrderDetails o on p.MedicineID = o.MedicineID and o.OrderDetailID = " +
                        int.Parse(data.Rows[i].ItemArray[0].ToString()) + " ORDER BY p.[TermofValidity(EXP)]); ";
                        new SqlCommand(updatePackage, connection).ExecuteNonQuery();
                    }
                        MessageBox.Show("Succeed!");
                    idReader.Close();
                    }
                    else MessageBox.Show("There is not enough medicines to complete this order!");

            }
            catch (Exception ex)
            {
                 String rollbackOrder = "UPDATE Orders SET RealizationFlag = 'N', RealizationDate = null, UserID = NULL WHERE OrderID = " + id + ";";
                 new SqlCommand(rollbackOrder, connection).ExecuteNonQuery();
                
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public DataRow getID(String username)
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            SqlCommand userIDCommand = new SqlCommand("select UserID, RoleID from Users where Username = '" + username + "';", connection);
            SqlDataReader sqlDataReader = userIDCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            DataRow dataRow = dataTable.Rows[0];
            connection.Close();
            return dataRow;
        }
        public void insertOrder(int pharmacistID)
        {
            connection.Open();
            int orderID;
            DataTable dt = new DataTable();
            SqlCommand orderIDCommand = new SqlCommand("select NEXT VALUE FOR medicinesOrderIDSeq;", connection);
            SqlDataReader reader = orderIDCommand.ExecuteReader();
            dt.Load(reader);
            DataRow dw = dt.Rows[0];
            orderID = int.Parse(dw[0].ToString());
            string insertMedicinesOrder = "insert into MedicinesOrders ([MedicinesOrderID],[UserID],[OrderDate],[RealizationFlag]) select " + orderID +
                "," + pharmacistID + ",CONVERT (date, SYSDATETIME()),'N';" +
                 "INSERT INTO MedicineOrderDetails ([MedicineOrderDetailsID],[MedicinesOrderID],[MedicineID],[Amount]) select NEXT VALUE FOR medicineOrderDetailsIdSeq MedicineOrderDetailsID, " + orderID +
                 " MedicinesOrderID, g.MedicineId MedicineID, g.Amount Amount from GenerateOrderView g;";

            new SqlCommand(insertMedicinesOrder, connection).ExecuteNonQuery();
            reader.Close();
            connection.Close();
        } 
        public void makeOrder(int pharmacistID, DataTable orderTable)
        {
            connection.Open();
            int orderID;
            DataTable dt = new DataTable();
            SqlCommand orderIDCommand = new SqlCommand("select NEXT VALUE FOR medicinesOrderIDSeq;", connection);
            SqlDataReader reader = orderIDCommand.ExecuteReader();
            dt.Load(reader);
            DataRow dw = dt.Rows[0];
            orderID = int.Parse(dw[0].ToString());
            string insertMedicinesOrder = "insert into MedicinesOrders ([MedicinesOrderID],[UserID],[OrderDate],[RealizationFlag]) select " + orderID +
                "," + pharmacistID + ",CONVERT (date, SYSDATETIME()),'N';";
            new SqlCommand(insertMedicinesOrder, connection).ExecuteNonQuery();
            for (int i = 0; i < orderTable.Rows.Count; i++)
            {
                string insertMedicineOrderDetail = "INSERT INTO MedicineOrderDetails ([MedicineOrderDetailsID],[MedicinesOrderID],[MedicineID],[Amount]) " +
                  "select NEXT VALUE FOR medicineOrderDetailsIdSeq MedicineOrderDetailsID, " + orderID + " MedicinesOrderID," 
                  + int.Parse(orderTable.Rows[i].ItemArray[0].ToString()) + " MedicineID," + int.Parse(orderTable.Rows[i].ItemArray[1].ToString()) + " Amount;";
                    new SqlCommand(insertMedicineOrderDetail, connection).ExecuteNonQuery();                
            }
            orderTable.Clear();
            reader.Close();
            connection.Close();
        }
    }   
}

