using Microsoft.AspNet.Identity.EntityFramework;
using PNACCompetitionsDbFirst.Models;
using PNACCompetitionsDbFirst.Models.ViewModels.Results;
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


    /// <summary>
    /// Complete the Points for the List<LengthResult>
    /// </summary>
    /// <param name="results"></param>
    public void Add(List<LengthResult> results)
    {
      int smaller, greater;

      if (results.Count > 0)
      {
        Competition competition = Competitions.Single(c => c.CompetitionId == results.First().Competition.CompetitionId);

        foreach (LengthResult result in results)
        {
          if(result.Competition.CompetitionId != competition.CompetitionId)
            competition = Competitions.Single(c => c.CompetitionId == result.Competition.CompetitionId);

          smaller = this.Catches.Where(c => c.Date <= competition.EndDateTime() && c.FishId == result.Fish.FishId && result.Length > c.Length).Count();
          greater = this.Catches.Where(c => c.Date <= competition.EndDateTime() && c.FishId == result.Fish.FishId && result.Length < c.Length).Count();

          result.Points = 100 * smaller / (smaller + greater);
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



    #endregion


    #region *********************** Interfaces ***********************
    #endregion

  }
}