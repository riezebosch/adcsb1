//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fibonacci.Test
{
    using System;
    using System.Collections.Generic;
    
    public partial class StateProvince
    {
        public StateProvince()
        {
            this.Addresses = new HashSet<Address>();
        }
    
        public int StateProvinceID { get; set; }
        public string StateProvinceCode { get; set; }
        public string CountryRegionCode { get; set; }
        public bool IsOnlyStateProvinceFlag { get; set; }
        public string Name { get; set; }
        public int TerritoryID { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual CountryRegion CountryRegion { get; set; }
    }
}
