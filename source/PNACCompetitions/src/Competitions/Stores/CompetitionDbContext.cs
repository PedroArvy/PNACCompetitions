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
          .HasOne(c => c.Competitor)
          .WithMany(c => c.CompetitorCompetitions)
          .HasForeignKey(c => c.CompetitorId)

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

    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
