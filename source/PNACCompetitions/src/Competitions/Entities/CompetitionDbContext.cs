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

    public DbSet<Club> Clubs { get; set; }

    public DbSet<Competition> Competitions { get; set; }

    public DbSet<Competitor> Competitors { get; set; }

    public DbSet<CompetitorCompetition> CompetitorCompetitions { get; set; }

    public DbSet<Fish> Fish { get; set; }

    public DbSet<Result> Results { get; set; }

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
      modelBuilder.Entity<Result>();
      modelBuilder.Entity<Season>();

      modelBuilder.Entity<Competition>().HasIndex(b => b.Start);

      modelBuilder.Entity<CompetitorCompetition>()
                    .HasKey(t => new { t.CompetitorId, t.CompetitionId });

      /*

            modelBuilder.Entity<Competitor>()
         .HasOne(c => c.Club)
         .WithMany(c => c.Competitors)
         .HasForeignKey(c => c.ClubId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);///////////////////


        */


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

      modelBuilder.Entity<Result>()
                     .HasKey(t => new { t.CompetitorId, t.CompetitionId, t.FishId });

      modelBuilder.Entity<Result>()
        .HasOne(r => r.Competitor)
        .WithMany(c => c.Results)
        .HasForeignKey(c => c.CompetitorId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);


      modelBuilder.Entity<Result>()
        .HasOne(r => r.Competition)
        .WithMany(c => c.Results)
        .HasForeignKey(c => c.CompetitionId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);

      modelBuilder.Entity<Result>()
        .HasOne(r => r.Fish)
        .WithMany(f => f.Results)
        .HasForeignKey(r => r.FishId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);

      /*
      modelBuilder.Entity<Competition>()
        .HasOne(c => c.TripCaptain)
        .WithMany(r => r.TripCaptaincies)
        .HasForeignKey(r => r.TripCaptainId).OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Restrict);
        */


      /*
      modelBuilder.Entity<Competition>()
        .HasOne(c => c.Referee1)
        .WithMany(r => r.RefereedCompetitions)
        .HasForeignKey(r => r.Referee1Id);

      modelBuilder.Entity<Competition>()
        .HasOne(c => c.Referee2)
        .WithMany(r => r.RefereedCompetitions)
        .HasForeignKey(r => r.Referee2Id);


      modelBuilder.Entity<Season>()
        .HasOne(s => s.Club)
        .WithMany(r => r.Seasons)
        .HasForeignKey(r => r.ClubId);
        */


    }


    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
