﻿using Competitions.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System;
using System.Linq;

namespace Competitions.Entities
{
  public class CompetitionDbContext : IdentityDbContext<Competitor>
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


    #endregion


    #region *********************** Methods **************************


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

  */
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}
