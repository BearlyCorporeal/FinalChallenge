//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalChallengeAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer0136
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer0136()
        {
            this.Sale0136 = new HashSet<Sale0136>();
        }
    
        public int CustNo { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public int CustPCode { get; set; }
        public string InterestCode { get; set; }
    
        public virtual Interest0136 Interest0136 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale0136> Sale0136 { get; set; }
    }
}
