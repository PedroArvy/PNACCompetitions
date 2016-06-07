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


    private List<SelectListItem> Entrants(Competition competition)
    {
      return competition.Entries.Select(entry => new SelectListItem {  Text = entry.Competitor.FriendlyName(), Value = entry.CompetitorId.ToString() }).OrderBy(m => m.Text).ToList();
    }


    public ActionResult New(int id)
    {
      Competition competition = db.Competitions.Single(c => c.CompetitionId == id);
      ResultEdit result = new ResultEdit();

      if (competition.CanAddEntries(Competitor))
      {
        result.CompetitionId = id;
        result.Entrants = Entrants(competition);
        result.Fish = Species(competition);
        result.Lengths = NumericalList(20, 200);
        result.Numbers = NumericalList(1, 50);
      }
      else
        throw new UnauthorizedAccessException("New");

      return View(result);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult New(ResultEdit result)
    {
      Competition competition = db.Competitions.Single(c => c.CompetitionId == result.CompetitionId);

      if (competition.CanAddEntries(Competitor))
      {
        if(ModelState.IsValid)
        {
          return View(result);
        }
        else
        {
          result.Entrants = Entrants(competition);
          result.Fish = Species(competition);
          result.Lengths = NumericalList(20, 200);
          result.Numbers = NumericalList(1, 50);

          return View(result);
        }
      }
      else
        throw new UnauthorizedAccessException("New");

    }


    private List<SelectListItem> NumericalList(int min, int max)
    {
      SelectListItem item;
      List<SelectListItem> items = new List<SelectListItem>();

      for(int i = min; i <= max; i++)
      {
        item = new SelectListItem() { Text = i.ToString(), Value = i.ToString() };
        items.Add(item);
      }

      return items;
    }


    private IEnumerable<SelectListItem> Species(Competition competition)
    {
      List<SelectListItem> items = new List<SelectListItem>();

      foreach (Fish fish in db.Fish)
      {
        if (fish.HasEnvironment(competition.Environment))
          items.Add(new SelectListItem { Value = fish.FishId.ToString(), Text = fish.Name });
      }

      return items.OrderBy(m => m.Text);
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}