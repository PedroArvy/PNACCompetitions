using Competitions.POCO;
using Microsoft.Data.Entity;

namespace Competitions.Stores
{
  public class CompetitionDbContext : DbContext
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public DbSet<Competition> Competitions { get; set; }

    public DbSet<Competitor> Competitors { get; set; }

    public DbSet<Fish> Fish { get; set; }

    public DbSet<Result> Results { get; set; }

    public DbSet<Season> Season { get; set; }

    #endregion


    #region *********************** Initialisation *******************


    #endregion


    #region *********************** Methods **************************

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Competition>();
      modelBuilder.Entity<Competitor>();
      //modelBuilder.Entity<CompetitorResult>();
      modelBuilder.Entity<CompetitorCompetition>();
      modelBuilder.Entity<Fish>();
      modelBuilder.Entity<Result>();
      modelBuilder.Entity<Season>();

      modelBuilder.Entity<CompetitorCompetition>().HasIndex(b => b.CompetitionId);

      modelBuilder.Entity<Competition>().HasIndex(b => b.Start);


      modelBuilder.Entity<CompetitorCompetition>()
                     .HasKey(t => new { t.CompetitorId, t.CompetitionId });

      modelBuilder.Entity<CompetitorCompetition>()
          .HasOne(pt => pt.Competitor)
          .WithMany(p => p.CompetitorCompetitions)
          .HasForeignKey(pt => pt.CompetitorId);

      modelBuilder.Entity<CompetitorCompetition>()
          .HasOne(c => c.Competition)
          .WithMany(c => c.CompetitorCompetitions)
          .HasForeignKey(c => c.CompetitionId);


      modelBuilder.Entity<Result>()
                     .HasKey(t => new { t.CompetitorId, t.CompetitionId, t.FishId });

      modelBuilder.Entity<Result>()
        .HasOne(r => r.Competitor)
        .WithMany(c => c.Results)
        .HasForeignKey(c => c.CompetitorId);

      modelBuilder.Entity<Result>()
        .HasOne(r => r.Competition)
        .WithMany(c => c.Results)
        .HasForeignKey(c => c.CompetitionId);

      modelBuilder.Entity<Result>()
        .HasOne(r => r.Fish)
        .WithMany(f => f.Results)
        .HasForeignKey(r => r.FishId);



      //modelBuilder.Entity<CompetitorResult>()
      //  .HasKey(t => new { t.CompetitorId, t.ResultId });
      /*
      modelBuilder.Entity<CompetitorResult>()
          .HasOne(pt => pt.Competitor)
          .WithMany(p => p.CompetitorResults)
          .HasForeignKey(pt => pt.CompetitorId);

      modelBuilder.Entity<CompetitorResult>()
          .HasOne(pt => pt.Competition)
          .WithMany(t => t.CompetitorCompetitions)
          .HasForeignKey(pt => pt.CompetitionId);*/

      /*
      modelBuilder.Entity<CompetitorResult>().HasOne(c => c.Competitor).WithMany(c => c.CompetitorResults).HasForeignKey(c => c.CompetitorId).will


        modelBuilder.Entity<Course>()
    .HasRequired(t => t.Department)
    .WithMany(t => t.Courses)
    .HasForeignKey(d => d.DepartmentID)
    .WillCascadeOnDelete(false);

      modelBuilder.Entity<Competitor>().HasMany(i => i.CompetitorResults).WithOne().WillCascadeOnDelete(false);
      modelBuilder.Entity<Result>().HasMany(i => i.CompetitorResults).WithOne().WillCascadeOnDelete(false);

      modelBuilder.Entity<Competitor>().HasMany(i => i.CompetitorCompetitions).WithOne().WillCascadeOnDelete(false);
      modelBuilder.Entity<Competition>().HasMany(i => i.CompetitorCompetitions).WithOne().WillCascadeOnDelete(false);
      */


    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
