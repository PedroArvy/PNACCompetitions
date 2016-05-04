using Competitions.Entities;
using Microsoft.Data.Entity;
using System;

namespace Competitions.Entities
{
  public class CompetitionDbContext : DbContext
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public DbSet<Catch> Catches { get; set; }

    public DbSet<Club> Clubs { get; set; }

    public DbSet<Competition> Competitions { get; set; }

    public DbSet<Competitor> Competitors { get; set; }

    public DbSet<Fish> Fish { get; set; }

    public DbSet<Season> Seasons { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Club>();
      modelBuilder.Entity<Competition>();
      modelBuilder.Entity<Competitor>();
      modelBuilder.Entity<Fish>();
      modelBuilder.Entity<Catch>();
      modelBuilder.Entity<Season>();

      modelBuilder.Entity<Competition>().HasIndex(b => b.Start);

      modelBuilder.Entity<Season>()
         .HasOne(s => s.Club)
         .WithMany(c => c.Seasons)
         .HasForeignKey(c => c.ClubId);


      modelBuilder.Entity<Catch>()
                     .HasKey(t => new { t.CompetitorId, t.CompetitionId, t.FishId });

      //when deleting a Catch do not delete a Competitor
      modelBuilder.Entity<Catch>()
        .HasOne(r => r.Competitor)
        .WithMany(c => c.Catches)
        .HasForeignKey(c => c.CompetitorId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);

      //when deleting a Catch do not delete a Competition
      modelBuilder.Entity<Catch>()
        .HasOne(r => r.Competition)
        .WithMany(c => c.Catches)
        .HasForeignKey(c => c.CompetitionId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);

      //when deleting a Catch do not delete a Fish
      modelBuilder.Entity<Catch>()
        .HasOne(r => r.Fish)
        .WithMany(f => f.Results)
        .HasForeignKey(r => r.FishId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);

      //when deleting a Competitor delete their Catches
      modelBuilder.Entity<Competitor>()
        .HasMany(c => c.Catches)
        .WithOne(f => f.Competitor)
        .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);

    }


    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
