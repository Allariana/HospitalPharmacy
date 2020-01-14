using System;
using System.Data;

namespace HospitalPharmacy
{
    class ObjectsController
    {
        private static ObjectsController instance; //singleton

        private ObjectsController() { } //żeby żadna inna klasa nie mogła go stworzyć

        public static ObjectsController getInstance()
        {
            if (instance == null)
            {
                instance = new ObjectsController();
            }
            return instance;
        }
        public DataTable basketDataTable = new DataTable();
        public DataTable packagesBasketDataTable = new DataTable();
        public void addColumn (DataTable basketDataTable)
        {
            DataColumnCollection columns = basketDataTable.Columns;
            if (columns.Contains("MedicineID")) { }
            else
            {
                basketDataTable.Columns.Add("MedicineID", typeof(String));
                basketDataTable.Columns.Add("Amount", typeof(String));
            }
        }
        public void addBasketColumn(DataTable packagesBasketDataTable)
        {
            DataColumnCollection columns = packagesBasketDataTable.Columns;
            if (columns.Contains("SerialNumber(SN)")) { }
            else
            {
                packagesBasketDataTable.Columns.Add("SerialNumber(SN)", typeof(String));              
            }
        }
    }
}
