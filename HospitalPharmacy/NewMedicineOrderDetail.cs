//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalPharmacy
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewMedicineOrderDetail
    {
        public int NewMedicineOrderDetailsID { get; set; }
        public int NewMedicineOrderID { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> MedicineID { get; set; }
    
        public virtual Medicine Medicine { get; set; }
        public virtual NewMedicineOrder NewMedicineOrder { get; set; }
    }
}
