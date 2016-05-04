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

    public DbSet<CompetitorCompetition> CompetitorCompetitions { get; set; }

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
      //modelBuilder.Entity<CompetitorResult>();
      modelBuilder.Entity<CompetitorCompetition>();
      modelBuilder.Entity<Fish>();
      modelBuilder.Entity<Catch>();
      modelBuilder.Entity<Season>();

      modelBuilder.Entity<Competition>().HasIndex(b => b.Start);

      modelBuilder.Entity<CompetitorCompetition>()
                    .HasKey(t => new { t.CompetitorId, t.CompetitionId });



      modelBuilder.Entity<Season>()
         .HasOne(s => s.Club)
         .WithMany(c => c.Seasons)
         .HasForeignKey(c => c.ClubId);


      modelBuilder.Entity<CompetitorCompetition>()
         .HasOne(c => c.Competitor)
         .WithMany(c => c.CompetitorCompetitions)
         .HasForeignKey(c => c.CompetitorId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);


      modelBuilder.Entity<CompetitorCompetition>()
       .HasOne(c => c.Competition)
       .WithMany(c => c.CompetitorCompetitions)
       .HasForeignKey(c => c.CompetitionId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);

      modelBuilder.Entity<Catch>()
                     .HasKey(t => new { t.CompetitorId, t.CompetitionId, t.FishId });

      modelBuilder.Entity<Catch>()
        .HasOne(r => r.Competitor)
        .WithMany(c => c.Catches)
        .HasForeignKey(c => c.CompetitorId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);

      modelBuilder.Entity<Catch>()
        .HasOne(r => r.Competition)
        .WithMany(c => c.Catches)
        .HasForeignKey(c => c.CompetitionId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);

      modelBuilder.Entity<Catch>()
        .HasOne(r => r.Fish)
        .WithMany(f => f.Results)
        .HasForeignKey(r => r.FishId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);


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
