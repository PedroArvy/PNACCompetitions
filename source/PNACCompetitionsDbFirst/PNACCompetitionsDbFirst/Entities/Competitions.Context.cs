﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PNACCompetitionsEntities : DbContext
    {
        public PNACCompetitionsEntities()
            : base("name=PNACCompetitionsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Catch> Catches { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Environment> Environments { get; set; }
        public virtual DbSet<Fish> Fish { get; set; }
        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<Competitor> Competitors { get; set; }
    }
}
