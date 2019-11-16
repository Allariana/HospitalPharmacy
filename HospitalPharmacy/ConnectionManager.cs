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
        
        public void pickUpOrder(String MedicineOrderID)
        {
            int id = int.Parse(MedicineOrderID.ToString());
            connection.Open();
            try
            {
                
                String pickUpOrderCommand = "UPDATE MedicinesOrders SET RealizationFlag = 'Y', RealizationDate = CONVERT (date, SYSDATETIME()) where MedicinesOrderID " +
                    "= " + id + "; " +
                    " UPDATE Medicines SET UnitsInStock = UnitsInStock + (select d.Amount from MedicineOrderDetails d join Medicines m on m.MedicineID = d.MedicineID join " +
                    "MedicinesOrders o on d.MedicinesOrderID = o.MedicinesOrderID and o.MedicinesOrderID = " + id + " and m.MedicineID = Medicines.MedicineID);"                   ;
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
        public void insertOrder(String username)
        {
            connection.Open();
            int orderID,pharmacistID;
            DataTable dt = new DataTable();
            DataTable dataTable = new DataTable();
            SqlCommand orderIDCommand = new SqlCommand("select NEXT VALUE FOR medicinesOrderIDSeq;", connection);
            SqlDataReader reader = orderIDCommand.ExecuteReader();
            dt.Load(reader);
            DataRow dw = dt.Rows[0];
            DataRow data = dt.Rows[0];
            orderID = int.Parse(dw[0].ToString());   
            SqlCommand pharmacistIDCommand = new SqlCommand("select p.PharmacistID from Pharmacists p join Users u on p.UserID=u.UserID where u.Username = '" 
                + username + "';", connection);
            SqlDataReader sqlDataReader = pharmacistIDCommand.ExecuteReader();
            dataTable.Load(sqlDataReader);
            data = dataTable.Rows[0];
            pharmacistID = int.Parse(data[0].ToString());
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
            sqlDataReader.Close();
            reader.Close();
            connection.Close();
        } 
    }   
}

