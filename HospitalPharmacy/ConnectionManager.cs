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
        public DataTable getPrice(DataTable price)
        {
            connection.Open();
            String command = "select SUM(Price) price from GenerateOrderView;";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            adapter.Fill(price);
            connection.Close();
            return price;
        }
        public void insertOrder()
        {
                connection.Open();
                //string insertOrder = "insert into NewMedicineOrders([NewMedicineOrderID]) values (1);";
                string insertNewMedicinesOrderDetails = "insert into NewMedicineOrders([NewMedicineOrderID]) values (1);" +
                "INSERT INTO NewMedicineOrderDetails " +
                    "select NEXT VALUE FOR dbo.newMedicineOrderDetails_id_seq NewMedicineOrderDetailsID,1 NewMedicineOrderID, MedicineId, " +
                    "dbo.Medicines.RequiredQuantity - dbo.Medicines.UnitsInStock Amount, " +
                    "dbo.Medicines.[UnitPrice(EUR)] * (dbo.Medicines.RequiredQuantity - dbo.Medicines.UnitsInStock) Price from Medicines;";
                new SqlCommand(insertNewMedicinesOrderDetails, connection).ExecuteNonQuery();
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

