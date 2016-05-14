using PNACCompetitionsDbFirst.Controllers;
using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Models;
using PNACCompetitionsDbFirst.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PNACCompetitionsDbFirst.Controllers
{
  public class CompetitionsController : PNACController
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

    private void AssignModel(Competition competition, CompetitionEdit model)
    {
      /*

      competition.Name = model.Name;
      competition.Minimum = model.Minimum;
      competition.Maximum = model.Maximum;
      competition.Difficulty = model.Difficulty;

      competition.Environments.ToList().RemoveRange(0, competition.Environments.Count());

      if (model.EnvironmentFreshwater)
        competition.Environments.Add(db.Environments.Single(e => e.EnvironmentId == Competition.FRESHWATER));

      if (model.EnvironmentEstuary)
        competition.Environments.Add(db.Environments.Single(e => e.EnvironmentId == Competition.ESTUARY));

      if (model.EnvironmentSaltwater)
        competition.Environments.Add(db.Environments.Single(e => e.EnvironmentId == Competition.SALTWATER));
        */
    }


    private bool CanEdit(Competitor competitor)
    {
      /*
      bool canEdit = false;

      if (Competitor != null && (Competitor.CompetitorId == competitor.CompetitorId || Competitor.Admin))
        canEdit = true;

      return canEdit;
      */
      return false;
    }


    public ActionResult Edit(int id)
    {
      Competition competition = db.Competitions.SingleOrDefault(c => c.CompetitionId == id);
      CompetitionEdit edit = new CompetitionEdit();

      if (Competitor.Admin)
      {
        edit.CompetitionId = competition.CompetitionId;
        edit.Venue = competition.Venue;
        edit.StartDate = Format.DateOnly(competition.Start);
      }
      else
        throw new NotImplementedException();

      return View(edit);
    }


    [HttpPost]
    public ActionResult Edit(CompetitionEdit model)
    {
      /*
      CompetitionEdit edit = new CompetitionEdit();
      Competition competition = db.Competition.SingleOrDefault(c => c.CompetitionId == model.CompetitionId);

      if (IsAdmin && ModelState.IsValid)
      {
        AssignModel(competition, model);

        db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (IsAdmin && !ModelState.IsValid)
        return View(model);
      else if (!IsAdmin)
        throw new UnauthorizedAccessException("");
        */
      return new EmptyResult();
    }


    public ActionResult Index()
    {
      IEnumerable<Competition> competition = db.Competitions.OrderBy(c => c.Name);
      CompetitionListItem competitionListItem;
      CompetitionIndex index = new CompetitionIndex();

      index.CompetitionListItems = new List<CompetitionListItem>();
      bool canEdit = IsAdmin;

      foreach (Competition competition_ in db.Competitions.OrderByDescending(c => c.Start).ThenBy(c => c.Venue))
      {
        competitionListItem = new CompetitionListItem()
        {
          CompetitionId = competition_.CompetitionId,
          Venue = competition_.Venue,
          Start = competition_.Start,
            CanEdit = canEdit, WeighIn = competition_.WeighInDescription()

        };

        if (!competition_.SingleDay())
          competitionListItem.End = (DateTime)competition_.End;

        index.CompetitionListItems.Add(competitionListItem);
      }

      if (Competitor != null)
        index.CanCreate = Competitor.Admin;

      return View(index);
    }


    public ActionResult New()
    {
      CompetitionEdit edit = new CompetitionEdit();
      return View(edit);
    }


    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public ActionResult New(CompetitionEdit model)
    {
      CompetitionEdit edit = new CompetitionEdit();
      Competition competition = new Competition();

      if (IsAdmin && ModelState.IsValid)
      {
        AssignModel(competition, model);

        //db.Competition.Add(competition);
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      else if (IsAdmin && !ModelState.IsValid)
        return View(model);
      else if (!IsAdmin)
        throw new UnauthorizedAccessException("");

      return new EmptyResult();
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}