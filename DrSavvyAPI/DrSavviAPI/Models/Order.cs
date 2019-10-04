//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrSavviAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Backlogs = new HashSet<Backlog>();
            this.Order_Line = new HashSet<Order_Line>();
            this.Order_Payment = new HashSet<Order_Payment>();
        }
    
        public int OrderID { get; set; }
        public decimal Order_Cost { get; set; }
        public int OS_ID { get; set; }
        public int Supplier_ID { get; set; }
        public Nullable<System.DateTime> Order_Date { get; set; }
        public Nullable<bool> PaidStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Backlog> Backlogs { get; set; }
        public virtual Order_Status Order_Status { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Line> Order_Line { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Payment> Order_Payment { get; set; }
    }
}
