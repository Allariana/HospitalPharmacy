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
    
    public partial class User
    {
        public User()
        {
            this.Administrators = new HashSet<Administrator>();
            this.Pharmacists = new HashSet<Pharmacist>();
        }
    
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Administrator> Administrators { get; set; }
        public virtual ICollection<Pharmacist> Pharmacists { get; set; }
    }
}
