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