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
    
    public partial class Medical_Aid_Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medical_Aid_Company()
        {
            this.Medical_Aid_Scheme = new HashSet<Medical_Aid_Scheme>();
        }
    
        public int Company_ID { get; set; }
        public string Company_Name { get; set; }
        public string ContactPerson { get; set; }
        public string Contact_Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medical_Aid_Scheme> Medical_Aid_Scheme { get; set; }
    }
}
