using Competitions.Entities;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System;
using System.Linq;

namespace Competitions.Entities
{
  public class CompetitionDbContext : DbContext
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    //public DbSet<Catch> Catches { get; set; }

    public DbSet<Club> Clubs { get; set; }

    //public DbSet<Competition> Competitions { get; set; }

   // public DbSet<Competitor> Competitors { get; set; }

    //public DbSet<Fish> Fish { get; set; }

    public DbSet<Season> Seasons { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Club>();
      //modelBuilder.Entity<Competition>();
      //modelBuilder.Entity<Competitor>();
     // modelBuilder.Entity<Fish>();
     // modelBuilder.Entity<Catch>();
      modelBuilder.Entity<Season>();

      //modelBuilder.Entity<Competition>().HasIndex(b => b.Start);

      //CascadeDeletes1(modelBuilder);
      //CascadeDeletes2(modelBuilder);
      //Restrict(modelBuilder);


      modelBuilder.Entity<Competition>()
        .HasOne(r => r.Season)
        .WithMany(f => f.Competitions)
        .HasForeignKey(r => r.SeasonId).OnDelete(DeleteBehavior.Restrict);

      modelBuilder.Entity<Catch>()
        .HasOne(r => r.Competitor)
        .WithMany(f => f.Catches)
        .HasForeignKey(r => r.CompetitorId).OnDelete(DeleteBehavior.Restrict);

    }


    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
