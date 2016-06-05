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

    private List<Entrant> Entrants(Competition competition)
    {
      return competition.Entries.Select(entry => new Entrant { Name = entry.Competitor.FriendlyName(), CompetitorId = entry.CompetitorId }).ToList();
    }


    public ActionResult New(int id)
    {
      Competition competition = db.Competitions.Single(c => c.CompetitionId == id);
      ResultEdit result = new ResultEdit();

      if (competition.CanAddEntries(Competitor))
      {
        result.Entrants = Entrants(competition);
        result.Species = Species(competition);
        result.Length = 20;
      }
      else
        throw new UnauthorizedAccessException("New");

      return View(result);
    }


    private List<Species> Species(Competition competition)
    {
      List<Species> species = new List<Models.ViewModels.Species>();

      foreach (Fish fish in db.Fish)
      {
        if (fish.HasEnvironment(competition.Environment))
          species.Add(new Models.ViewModels.Species() { FishId = fish.FishId, Name = fish.Name });
      }

      return species;
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}