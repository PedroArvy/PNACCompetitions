using PNACCompetitions.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Linq;
using System.Data.Entity;
using PNACCompetitions.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PNACCompetitions.Entities
{
  public class CompetitionDbContext : IdentityDbContext<ApplicationUser>
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public DbSet<Catch> Catches { get; set; }

    public DbSet<Club> Clubs { get; set; }

    public DbSet<Competition> Competitions { get; set; }

    public DbSet<Entry> Entries { get; set; }

    public DbSet<Competitor> Competitors { get; set; }

    public DbSet<Fish> Fish { get; set; }

    public DbSet<FishRule> FishRules { get; set; }

    public DbSet<Season> Seasons { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public static CompetitionDbContext Create()
    {
      return new CompetitionDbContext();
    }


    //Add-Migration v1
    //update-database -verbose
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

      modelBuilder.Entity<Competition>().HasRequired(m => m.Club).WithMany(t => t.Competitions).WillCascadeOnDelete(true);
      modelBuilder.Entity<Competitor>().HasRequired(m => m.Club).WithMany(t => t.Competitors).WillCascadeOnDelete(true);
      modelBuilder.Entity<Entry>().HasRequired(m => m.Competitor).WithMany(t => t.Entries).WillCascadeOnDelete(true);
      modelBuilder.Entity<Catch>().HasRequired(m => m.Entry).WithMany(t => t.Catches).WillCascadeOnDelete(true);
      modelBuilder.Entity<FishRule>().HasRequired(m => m.Fish).WithMany(t => t.FishRules).WillCascadeOnDelete(true);
      modelBuilder.Entity<Season>().HasRequired(m => m.Club).WithMany(t => t.Seasons).WillCascadeOnDelete(true);

      modelBuilder.Entity<FishRule>().HasRequired(m => m.Club).WithMany(t => t.FishRule).WillCascadeOnDelete(true);
      //modelBuilder.Entity<Entry>().HasRequired(m => m.Competition).WithMany(t => t.Entries).WillCascadeOnDelete(true);

      //modelBuilder.Entity<Competitor>().HasMany(c => c.Entries).WithRequired().WillCascadeOnDelete(true);
      //modelBuilder.Entity<Entry>().HasMany(c => c.Catches).WithRequired().WillCascadeOnDelete(true);

      //modelBuilder.Entity<FishRule>().HasRequired(s => s.Club).WithMany(c => c.FishRule).WillCascadeOnDelete(false);
      // modelBuilder.Entity<Competition>().HasMany(i => i.Entries).WithRequired().WillCascadeOnDelete(false);

      //modelBuilder.Entity<Competitor>().HasRequired(s => s.Club).WithMany(c => c.Competitors).WillCascadeOnDelete(false);

      //modelBuilder.Entity<Competitor>().HasRequired(s => s.Club).WithMany(c => c.Competitors).WillCascadeOnDelete(false);
      //modelBuilder.Entity<Fish>().HasRequired(s => s.Club).WithMany(c => c.Fish).WillCascadeOnDelete(false);

      //modelBuilder.Entity<Catch>().HasRequired(s => s.Fish).WithMany(c => c.Catches).WillCascadeOnDelete(false);

      // modelBuilder.Entity<Club>().HasMany(i => i.Competitions).WithRequired().WillCascadeOnDelete(true);

      //modelBuilder.Entity<Season>().HasRequired(s => s.Club).WithMany(c => c.Seasons).WillCascadeOnDelete(true);

      // modelBuilder.Entity<Season>().HasRequired(s => s.Club).WithMany(c => c.Seasons).WillCascadeOnDelete(false);
      //   modelBuilder.Entity<Catch>().HasRequired(s => s.Competition).WithMany(c => c.Catches).WillCascadeOnDelete(false);
      //modelBuilder.Entity<Competition>().HasRequired(s => s.Club).WithMany(c => c.Competitions).WillCascadeOnDelete(false);
      //   modelBuilder.Entity<Competitor>().HasRequired(s => s.Club).WithMany(c => c.Competitors).WillCascadeOnDelete(false);
      //   modelBuilder.Entity<Season>().HasRequired(s => s.Club).WithMany(c => c.Seasons).WillCascadeOnDelete(false);

      // modelBuilder.Entity<Club>().HasMany(i => i.FishRule).WithRequired().WillCascadeOnDelete(true);

      //modelBuilder.Entity<Club>().HasMany(i => i.Competitions).WithRequired().WillCascadeOnDelete(true);
      //modelBuilder.Entity<Club>().HasMany(i => i.Seasons).WithRequired().WillCascadeOnDelete(true);
      //modelBuilder.Entity<Club>().HasMany(i => i.Fish).WithRequired().WillCascadeOnDelete(true);

      //modelBuilder.Entity<Season>().HasMany(i => i.Competitions).WithRequired().WillCascadeOnDelete(true);
      //modelBuilder.Entity<Competition>().HasMany(i => i.Catches).WithRequired().WillCascadeOnDelete(true);
    }

  }


  /*
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Club>();
    modelBuilder.Entity<Competition>();
    modelBuilder.Entity<Competitor>();
    modelBuilder.Entity<Fish>();
    modelBuilder.Entity<Catch>();
    modelBuilder.Entity<Season>();

    //modelBuilder.Entity<Competition>().HasIndex(b => b.Start);

    //CascadeDeletes1(modelBuilder);
    //CascadeDeletes2(modelBuilder);
    //Restrict(modelBuilder);

    //don't delete a Season when you delete a Competition
    modelBuilder.Entity<Competition>()
      .HasOne(r => r.Season)
      .WithMany(f => f.Competitions)
      .HasForeignKey(r => r.SeasonId).OnDelete(DeleteBehavior.Restrict);

    //don't delete a Competitor when you delete a Catch
    modelBuilder.Entity<Catch>()
      .HasOne(r => r.Competitor)
      .WithMany(f => f.Catches)
      .HasForeignKey(r => r.CompetitorId).OnDelete(DeleteBehavior.Restrict);

    //don't delete a Fish when you delete a Catch
    modelBuilder.Entity<Catch>()
      .HasOne(r => r.Fish)
      .WithMany(f => f.Catches)
      .HasForeignKey(r => r.CompetitorId).OnDelete(DeleteBehavior.Restrict);
  }
  */

  #endregion


  #region *********************** Methods **************************

  /*
  private void Restrict(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Catch>()
      .HasOne(r => r.Competitor)
      .WithMany(c => c.Catches)
      .HasForeignKey(c => c.CompetitorId).OnDelete(DeleteBehavior.Restrict);


    //when deleting a Catch do not delete a Competition
    modelBuilder.Entity<Catch>()
      .HasOne(r => r.Competition)
      .WithMany(c => c.Catches)
      .HasForeignKey(c => c.CompetitionId).OnDelete(DeleteBehavior.Restrict);


    //when deleting a Catch do not delete a Fish
    modelBuilder.Entity<Catch>()
      .HasOne(r => r.Fish)
      .WithMany(f => f.Catches)
      .HasForeignKey(r => r.FishId).OnDelete(DeleteBehavior.Restrict);


    modelBuilder.Entity<Competition>()
      .HasOne(r => r.Club)
      .WithMany(f => f.Competitions)
      .HasForeignKey(r => r.ClubId).OnDelete(DeleteBehavior.Restrict);


    modelBuilder.Entity<Competition>()
      .HasOne(r => r.Season)
      .WithMany(f => f.Competitions)
      .HasForeignKey(r => r.SeasonId).OnDelete(DeleteBehavior.Restrict);


    //when deleting a Competitor do not delete a Club
    modelBuilder.Entity<Competitor>()
       .HasOne(c => c.Club)
       .WithMany(c => c.Competitors)
       .HasForeignKey(c => c.ClubId).OnDelete(DeleteBehavior.Restrict);


    modelBuilder.Entity<Fish>()
       .HasOne(c => c.Club)
       .WithMany(c => c.Fish)
       .HasForeignKey(c => c.ClubId).OnDelete(DeleteBehavior.Restrict);


    modelBuilder.Entity<Season>()
       .HasOne(c => c.Club)
       .WithMany(c => c.Seasons)
       .HasForeignKey(c => c.ClubId).OnDelete(DeleteBehavior.Restrict);
  }


  private void CascadeDeletes1(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Competitor>()
      .HasOne(c => c.Club)
      .WithMany(c => c.Competitors)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Competition>()
      .HasOne(c => c.Club)
      .WithMany(c => c.Competitions)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Season>()
      .HasOne(c => c.Club)
      .WithMany(c => c.Seasons)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Fish>()
      .HasOne(c => c.Club)
      .WithMany(c => c.Fish)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Catch>()
      .HasOne(c => c.Competition)
      .WithMany(c => c.Catches)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Catch>()
      .HasOne(c => c.Competitor)
      .WithMany(c => c.Catches)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Catch>()
      .HasOne(c => c.Fish)
      .WithMany(c => c.Catches)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Competition>()
      .HasOne(c => c.Season)
      .WithMany(c => c.Competitions)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);
  }


  private void CascadeDeletes2(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Club>()
      .HasMany(c => c.Seasons)
      .WithOne(c => c.Club)
      .HasForeignKey(c => c.ClubId);
    // .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);



    /*
    modelBuilder.Entity<Club>()
      .HasMany(c => c.Competitors)
      .WithOne(c => c.Club)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Club>()
      .HasMany(c => c.Competitions)
      .WithOne(c => c.Club)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);



    modelBuilder.Entity<Club>()
      .HasMany(c => c.Fish)
      .WithOne(c => c.Club)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Competition>()
      .HasMany(c => c.Catches)
      .WithOne(c => c.Competition)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Competitor>()
      .HasMany(c => c.Catches)
      .WithOne(c => c.Competitor)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Fish>()
      .HasMany(c => c.Catches)
      .WithOne(c => c.Fish)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


    modelBuilder.Entity<Season>()
      .HasMany(c => c.Competitions)
      .WithOne(c => c.Season)
      .OnDelete(Microsoft.Data.Entity.Metadata.DeleteBehavior.Cascade);


  }
*/
  #endregion


  #region *********************** Interfaces ***********************
  #endregion

}
