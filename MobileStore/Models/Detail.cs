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
    
    public partial class Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Detail()
        {
            this.My_Order = new HashSet<My_Order>();
        }
    
        public int Details_Id { get; set; }
        public Nullable<int> Product_Id { get; set; }
        public string Product_Name { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Discount { get; set; }
        public string Warenty { get; set; }
        public string Buy { get; set; }
    
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<My_Order> My_Order { get; set; }
        public virtual Payment_Detail Payment_Details { get; set; }
    }
}
