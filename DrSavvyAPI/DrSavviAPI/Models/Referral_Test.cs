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
    
    public partial class Referral_Test
    {
        public int ReferralTestID { get; set; }
        public int Ref_ID { get; set; }
        public string TestRemarks { get; set; }
        public int TestID { get; set; }
        public Nullable<int> Institute_ID { get; set; }
    
        public virtual Institute Institute { get; set; }
        public virtual Referral Referral { get; set; }
        public virtual Test Test { get; set; }
    }
}
