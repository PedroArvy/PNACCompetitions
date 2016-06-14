﻿using Microsoft.AspNet.Identity.EntityFramework;
using PNACCompetitionsDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Entities
{
  public partial class PNACCompetitionsEntities //: IdentityDbContext<ApplicationUser>
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************


    private void AddLengthPoints(List<CompetitionPoint> lengthPoints, List<LeaderBoardItem> items)
    {
      LeaderBoardItem nextItem;

      foreach (LeaderBoardItem item in items)
      {
        nextItem = items.SingleOrDefault(p => p.Competitor.CompetitorId == item.Competitor.CompetitorId);

        if (nextItem == null)
        {
          nextItem = new LeaderBoardItem();
          nextItem.Competitor = item.Competitor;
          nextItem.Points = item.Points;
        }
        else
        {
          nextItem.Points += item.Points;
        }
      }
    }


    /// <summary>
    /// Clean up competitors after import from Tony Coon's Excel
    /// </summary>
    public void Clean()
    {
      IEnumerable<Competitor> competitors = Competitors.Where(c => c.FirstName.Contains("&"));
      Competitor newCompetitor;

      foreach (Competitor competitor in competitors)
      {
        newCompetitor = competitor.DuplicateSpouse();
        Competitors.Add(newCompetitor);
        competitor.FirstName = competitor.FirstName.Substring(0, competitor.FirstName.IndexOf("&") - 1);
      }

      SaveChanges();
    }


    public List<LeaderBoardItem> LeaderBoardLength(Season season)
    {
      List<LeaderBoardItem> items = new List<LeaderBoardItem>();

      List<CompetitionPoint> lengthPoints;

      foreach (Competition competition in SeasonCompetitions(season))
      {
        lengthPoints = competition.LengthPoints();
      }

      return items;
    }


    public IQueryable<Competition> SeasonCompetitions(Season season)
    {
      return Competitions.Where(c => c.Start > season.Start && c.Start < season.End);
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion

  }
}