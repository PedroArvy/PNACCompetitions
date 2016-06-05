using PNACCompetitionsDbFirst.Controllers;
using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Models;
using PNACCompetitionsDbFirst.Models.ViewModels;
using PNACCompetitionsDbFirst.Models.ViewModels.Components;
using PNACCompetitionsDbFirst.Models.ViewModels.Entries;
using PNACCompetitionsDbFirst.Models.ViewModels.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace PNACCompetitionsDbFirst.Controllers
{
  public class ResultsController : PNACController
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


    public ActionResult New(int id)
    {
      Competition competition = db.Competitions.Single(c => c.CompetitionId == id);

      if (competition.CanAddEntries(Competitor))
      {
      }
      else
        throw new UnauthorizedAccessException("NewEntry");

      return null;
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}