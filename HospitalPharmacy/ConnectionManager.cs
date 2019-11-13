using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPharmacy
{
    class ConnectionManager
    {
        public SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Pharmacy;Integrated Security=True");

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
        public int getPrice()
        {
            int price;
            connection.Open();
            DataTable dt = new DataTable();
            SqlCommand priceCommand = new SqlCommand("SELECT SUM(Price) FROM GenerateOrderView;", connection);
            SqlDataReader reader = priceCommand.ExecuteReader();
            dt.Load(reader);
            DataRow dw = dt.Rows[0];
            price = int.Parse(dw[0].ToString());
            reader.Close();
            connection.Close();
            return price;
        }
        public void insertOrder(String username)
        {
            connection.Open();
            int orderID,pharmacistID;
            DataTable dt = new DataTable();
            DataTable dataTable = new DataTable();
            SqlCommand orderIDCommand = new SqlCommand("select NEXT VALUE FOR dbo.newmedicineorder_id_seq;", connection);
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
            string insertNewMedicinesOrderDetails = "insert into NewMedicineOrders ([NewMedicineOrderID],[PharmacistID],[OrderDate],[Price]) select " + orderID + 
                "," + pharmacistID + ",CONVERT (date, SYSDATETIME())," +
                "SUM(Price) from GenerateOrderView;" +
                "INSERT INTO NewMedicineOrderDetails " +
                    "select NEXT VALUE FOR dbo.newMedicineOrderDetails_id_seq NewMedicineOrderDetailsID," + orderID + " NewMedicineOrderID, MedicineId, " +
                    "dbo.Medicines.RequiredQuantity - dbo.Medicines.UnitsInStock Amount, " +
                    "dbo.Medicines.[UnitPrice(EUR)] * (dbo.Medicines.RequiredQuantity - dbo.Medicines.UnitsInStock) Price from Medicines;";
                new SqlCommand(insertNewMedicinesOrderDetails, connection).ExecuteNonQuery();
            sqlDataReader.Close();
            reader.Close();
            connection.Close();
        }
            
        }
        /*public void getTableWithCondition(String columnname, String tablename, String condition, String condition2, DataTable dataTable)
        {
            connection.Open();
            //if (condition2 is null) condition2 = "Seronil";
            //select [Dose(mg)] from Medicines where TradeName = 'Seronil';
            //String command = "select " + columnname + " from " + tablename + "where " + condition + " = " + condition2 + ";";
            String command = "select " + columnname + " from " + tablename + "where " + condition + " = 'Seronil';";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(dataTable);
            connection.Close();
        }*/
    }

