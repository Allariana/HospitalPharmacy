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
        public string TradeName { get; set; }
        public int Dose_mg_ { get; set; }
        public int QuantityPerUnit { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> SerialNumber { get; set; }
    
        public virtual NewMedicineOrder NewMedicineOrder { get; set; }
        public virtual PackageofMedicine PackageofMedicine { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
