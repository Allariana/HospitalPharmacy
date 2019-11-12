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
    
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderID { get; set; }
        public int DepartmentID { get; set; }
        public Nullable<int> PharmacistID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime RequiredDate { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Pharmacist Pharmacist { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
