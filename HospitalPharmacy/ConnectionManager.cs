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
        public void getTable(String tablename,String columnname, DataTable dataTable)
        {
            connection.Open();
            dataTable.Clear();
            String command = "select " + columnname + " from " + tablename + ";";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(dataTable);
            connection.Close();
        }       
        public void getMedicinesOrderDetails(DataTable dataTable, String MedicineOrderID)
        {
            connection.Open();
            int id = int.Parse(MedicineOrderID.ToString());
            String command = "select m.TradeName, m.ActiveSubstance, m.[Dose(mg)], m.QuantityPerUnit, m.[UnitPrice(EUR)], s.CompanyName, d.Amount, ROUND(d.Price,2) Total_price " +
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
        public void pickUpOrder(String MedicineOrderID)
        {
            int id = int.Parse(MedicineOrderID.ToString());
            char status;
            try
            {
                connection.Open();
                SqlCommand checkOrderStatus = new SqlCommand("select RealizationFlag from MedicinesOrders where MedicinesOrderID = " + id + ";", connection);
                SqlDataReader reader = checkOrderStatus.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow dw = dt.Rows[0];
                status = char.Parse(dw[0].ToString());
                reader.Close();
                if (status == 'N')
                {
                    String pickUpOrderCommand = "UPDATE MedicinesOrders SET RealizationFlag = 'Y', RealizationDate = CONVERT (date, SYSDATETIME()) where MedicinesOrderID " +
                    "= " + id + "; " +
                    " UPDATE Medicines SET UnitsInStock = UnitsInStock + " +
                    "(select a.Amount from(select d.MedicineID MedicineID, d.Amount Amount from MedicineOrderDetails d join Medicines m on m.MedicineID = d.MedicineID " +
                    "join MedicinesOrders o on     d.MedicinesOrderID = o.MedicinesOrderID and o.MedicinesOrderID = " + id + ")a join Medicines m on a.MedicineID = m.MedicineID " +
                    "and a.MedicineID = Medicines.MedicineID)where MedicineID in (select d.MedicineID from MedicineOrderDetails d join MedicinesOrders o on " +
                    "d.MedicinesOrderID = o.MedicinesOrderID and d.MedicinesOrderID = " + id + "); " /*+
                    "INSERT INTO PackageofMedicine SELECT CONVERT(INT, a.SerialNumber),CONVERT(INT, RIGHT(a.SerialNumber, 3)),a.TermofValidity, CONVERT(INT, a.LOT) " +
                    "FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0','Excel 12.0;Database=D:\Kinga\Studies\IV rok\Semestr 7\Praca dyplomowa\Files\Faktura_elektroniczna.xlsx', " +
                    "'SELECT * from [Arkusz1$]')a"   */                 ;
                new SqlCommand(pickUpOrderCommand, connection).ExecuteNonQuery();
                MessageBox.Show("Succeed!");
                }
                else MessageBox.Show("This order has already been completed!");
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
            char status;
            connection.Open();
                try
            {
                SqlCommand checkOrderStatus = new SqlCommand("select RealizationFlag from Orders where OrderID = " + id + ";", connection);
                SqlCommand checkIfEnoughMedicines = new SqlCommand("select TOP (1) Units from (select UnitsInStock - (select a.Amount from(select d.MedicineID MedicineID, " +
                    "d.Amount Amount from OrderDetails d join Medicines m on m.MedicineID = d.MedicineID join Orders o on d.OrderID = o.OrderID and o.OrderID = " + id + ")a " +
                    "join Medicines m on a.MedicineID = m.MedicineID and a.MedicineID = Medicines.MedicineID) Units from Medicines where MedicineID in " +
                    "(select d.MedicineID from OrderDetails d join Orders o on d.OrderID = o.OrderID and d.OrderID = " + id + "))b where Units < 0; ", connection);
                SqlDataReader reader = checkOrderStatus.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow dw = dt.Rows[0];
                status = char.Parse(dw[0].ToString());
                SqlDataReader reader2 = checkIfEnoughMedicines.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader2);
                reader2.Close();
                if (status == 'N')
                {
                    if (dataTable.Rows.Count == 0)
                    {
                        String completeOrderCommand = "UPDATE Orders SET RealizationFlag = 'Y', RealizationDate = CONVERT (date, SYSDATETIME()), PharmacistID = " + pharmacistID
                        + " where OrderID = " + id + ";" +
                        " UPDATE Medicines SET UnitsInStock = UnitsInStock - " +
                        "(select a.Amount from(select d.MedicineID MedicineID, d.Amount Amount from OrderDetails d join Medicines m on m.MedicineID = d.MedicineID " +
                        "join Orders o on d.OrderID = o.OrderID and o.OrderID = " + id + ")a join Medicines m on a.MedicineID = m.MedicineID " +
                        "and a.MedicineID = Medicines.MedicineID)where MedicineID in (select d.MedicineID from OrderDetails d join Orders o on " +
                        "d.OrderID = o.OrderID and d.OrderID = " + id + "); ";
                        new SqlCommand(completeOrderCommand, connection).ExecuteNonQuery();
                        MessageBox.Show("Succeed!");
                    }
                    else MessageBox.Show("There is not enough medicines to complete this order!");
                }
                else MessageBox.Show("This order has already been completed!");
            }
            catch (Exception ex)
            {
                 String rollbackOrder = "UPDATE Orders SET RealizationFlag = 'N', RealizationDate = null, PharmacistID = NULL WHERE OrderID = " + id + ";";
                 new SqlCommand(rollbackOrder, connection).ExecuteNonQuery();
                
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public String getPrice()
        {
            String price;
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand priceCommand = new SqlCommand("SELECT SUM(Price) FROM GenerateOrderView;", connection);
                SqlDataReader reader = priceCommand.ExecuteReader();
                dt.Load(reader);
                DataRow dw = dt.Rows[0];
                price = dw[0].ToString();
                reader.Close();
                connection.Close();
                return price;
            }
            catch(FormatException)
            {
                price = "0";
                return price;
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
            string insertMedicinesOrder = "insert into MedicinesOrders ([MedicinesOrderID],[PharmacistID],[OrderDate],[Price],[RealizationFlag]) select " + orderID +
                "," + pharmacistID + ",CONVERT (date, SYSDATETIME()),SUM(Price),'N' from GenerateOrderView;" +
                "INSERT INTO MedicineOrderDetails select NEXT VALUE FOR medicineOrderDetailsIdSeq MedicineOrderDetailsID, * from" +
                "(select " + orderID + " MedicinesOrderID, m.MedicineId,CASE WHEN((m.RequiredQuantity - m.UnitsInStock - " +
                "(select d.Amount from MedicineOrderDetails d join MedicinesOrders o on d.MedicinesOrderID = o.MedicinesOrderID" +
                " where d.MedicineID = m.MedicineID and o.RealizationFlag = 'N')))IS NULL THEN m.RequiredQuantity - m.UnitsInStock" +
                " ELSE(m.RequiredQuantity - m.UnitsInStock - (select d.Amount from MedicineOrderDetails d join MedicinesOrders o on d.MedicinesOrderID = o.MedicinesOrderID" +
                " where d.MedicineID = m.MedicineID and o.RealizationFlag = 'N'))   END Amount," +
                " ROUND(CASE WHEN((m.RequiredQuantity - m.UnitsInStock - (select d.Amount from MedicineOrderDetails d join MedicinesOrders o on" +
                " d.MedicinesOrderID = o.MedicinesOrderID where d.MedicineID = m.MedicineID and o.RealizationFlag = 'N')))IS NULL" +
                " THEN(m.RequiredQuantity - m.UnitsInStock) * m.[UnitPrice(EUR)] ELSE(m.RequiredQuantity - m.UnitsInStock -" +
                "(select d.Amount from MedicineOrderDetails d join MedicinesOrders o on d.MedicinesOrderID = o.MedicinesOrderID " +
                " where d.MedicineID = m.MedicineID and o.RealizationFlag = 'N'))*m.[UnitPrice(EUR)] END,2) AS Price from Medicines m)insertOrder" +
                " where insertOrder.Amount > 0;";

            new SqlCommand(insertMedicinesOrder, connection).ExecuteNonQuery();
            reader.Close();
            connection.Close();
        } 
    }   
}

