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
    
    public partial class Record0136
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Record0136()
        {
            this.Sale0136 = new HashSet<Sale0136>();
        }
    
        public string RecordID { get; set; }
        public string Title { get; set; }
        public string Preformer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale0136> Sale0136 { get; set; }
    }
}
