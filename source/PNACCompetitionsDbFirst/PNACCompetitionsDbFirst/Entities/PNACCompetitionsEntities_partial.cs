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


    /// <summary>
    /// Complete the Points for the List<LengthResult>
    /// </summary>
    /// <param name="results"></param>
    public void Add(List<LengthResult> results)
    {
      int smaller, greater;

      foreach(LengthResult result in results)
      {
        smaller = this.Catches.Where(c => c.FishId == result.Fish.FishId && result.Length > c.Length).Count();
        greater = this.Catches.Where(c => c.FishId == result.Fish.FishId && result.Length < c.Length).Count();

        result.Points = 100 * smaller / (smaller + greater);
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