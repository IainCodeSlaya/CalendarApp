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
    
    public partial class Order_Line
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order_Line()
        {
            this.Backlogs = new HashSet<Backlog>();
        }
    
        public int OrderLineID { get; set; }
        public decimal Prod_Qty { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Nullable<decimal> ReceivedQty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Backlog> Backlogs { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
