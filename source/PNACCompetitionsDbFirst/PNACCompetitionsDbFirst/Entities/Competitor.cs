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
    
    public partial class Competitor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Competitor()
        {
            this.Entries = new HashSet<Entry>();
        }
    
        public int CompetitorId { get; set; }
        public int CompetitorType { get; set; }
        public int Gender { get; set; }
        public int ClubId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string AspNetUserId { get; set; }
        public bool Admin { get; set; }
        public bool Hide { get; set; }
        public string Suburb { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Club Club { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry> Entries { get; set; }
    }
}
