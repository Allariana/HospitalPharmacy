using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
