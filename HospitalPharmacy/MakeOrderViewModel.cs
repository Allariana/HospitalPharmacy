using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPharmacy
{
    class MakeOrderViewModel
    {
        private static MakeOrderViewModel instance;
        private MakeOrderViewModel() { }
        public static MakeOrderViewModel getInstance()
        {
            if (instance == null)
            {
                instance = new MakeOrderViewModel();
            }
            return instance;
        }



        private static MakeOrderForm makeOrderForm;
        /*public static showForm()
        {
            makeOrderForm = new MakeOrderForm();
            makeOrderForm
        }*/

    }
}
