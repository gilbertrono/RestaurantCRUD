//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantCRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrder
    {
        public long OrderID { get; set; }
        public string OrderNo { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string PMethod { get; set; }
        public Nullable<decimal> GTotal { get; set; }
    
        public virtual tblCustomer tblCustomer { get; set; }
        public virtual tblOrder tblOrders1 { get; set; }
        public virtual tblOrder tblOrder1 { get; set; }
        public virtual tblOrder tblOrders11 { get; set; }
        public virtual tblOrder tblOrder2 { get; set; }
    }
}