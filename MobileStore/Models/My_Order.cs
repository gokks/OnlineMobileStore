//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class My_Order
    {
        public int Order_Id { get; set; }
        public Nullable<int> Product_Id { get; set; }
        public Nullable<int> Categories_Id { get; set; }
        public Nullable<int> Details_Id { get; set; }
        public Nullable<int> Payment_Id { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Detail Detail { get; set; }
        public virtual My_Order My_Order1 { get; set; }
        public virtual My_Order My_Order2 { get; set; }
        public virtual Payment_Detail Payment_Details { get; set; }
        public virtual Product Product { get; set; }
    }
}
