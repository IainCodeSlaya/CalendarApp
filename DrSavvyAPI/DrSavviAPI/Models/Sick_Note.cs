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
    
    public partial class Sick_Note
    {
        public int SN__ID { get; set; }
        public string SN__Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime DateGenerated { get; set; }
        public Nullable<int> Consultation_ID { get; set; }
    
        public virtual Consultation Consultation { get; set; }
    }
}
