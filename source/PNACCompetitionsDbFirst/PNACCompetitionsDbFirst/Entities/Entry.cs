//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PNACCompetitionsDbFirst.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entry()
        {
            this.Catches = new HashSet<Catch>();
        }
    
        public int EntryId { get; set; }
        public int CompetitorId { get; set; }
        public int CompetitionId { get; set; }
        public bool IsTripCaptain { get; set; }
        public bool IsReferee { get; set; }
    
        public virtual Competitor Competitor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Catch> Catches { get; set; }
        public virtual Competition Competition { get; set; }
    }
}
