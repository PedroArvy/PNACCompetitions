using Microsoft.AspNet.Identity.EntityFramework;
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


    private void AddPoints(List<CompetitionPoint> points, List<LeaderBoardItem> items)
    {
      LeaderBoardItem nextItem;

      foreach (CompetitionPoint point in points)
      {
        nextItem = items.SingleOrDefault(p => p.Competitor.CompetitorId == point.Competitor.CompetitorId);

        if (nextItem == null)
        {
          nextItem = new LeaderBoardItem();
          nextItem.Competitor = point.Competitor;
          nextItem.Points = point.CompetitionPoints;
          items.Add(nextItem);
        }
        else
        {
          nextItem.Points += point.CompetitionPoints;
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


    public Season Current()
    {
      DateTime now = DateTime.Now;
      return Seasons.SingleOrDefault(s => s.Start <= now && now <= s.End);
    }


    public List<LeaderBoardItem> LengthPoints(Season season)
    {
      List<LeaderBoardItem> items = new List<LeaderBoardItem>();
      List<CompetitionPoint> lengthPoints;
      int rank = 1;

      foreach (Competition competition in SeasonCompetitions(season))
      {
        lengthPoints = competition.LengthPoints();
        AddPoints(lengthPoints, items);
      }

      foreach(LeaderBoardItem item in items.OrderByDescending(l => l.Points))
      {
        item.Rank = rank;
        rank++;
      }

      return items;
    }


    public IQueryable<Competition> SeasonCompetitions(Season season)
    {
      return Competitions.Where(c => c.Start > season.Start && c.Start < season.End);
    }


    public List<LeaderBoardItem> WeightPoints(Season season)
    {
      List<LeaderBoardItem> items = new List<LeaderBoardItem>();
      List<CompetitionPoint> weightPoints;
      int rank = 1;

      foreach (Competition competition in SeasonCompetitions(season))
      {
        weightPoints = competition.WeightPoints();
        AddPoints(weightPoints, items);
      }

      foreach (LeaderBoardItem item in items.OrderByDescending(l => l.Points))
      {
        item.Rank = rank;
        rank++;
      }

      return items;
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}