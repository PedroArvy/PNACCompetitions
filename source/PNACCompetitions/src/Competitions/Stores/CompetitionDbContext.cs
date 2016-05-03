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
      modelBuilder.Entity<Fish>();
      modelBuilder.Entity<Result>();
      modelBuilder.Entity<Season>();
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
