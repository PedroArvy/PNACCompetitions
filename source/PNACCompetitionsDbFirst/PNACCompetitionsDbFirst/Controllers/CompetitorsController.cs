using PNACCompetitionsDbFirst.Entities;
using PNACCompetitionsDbFirst.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNACCompetitionsDbFirst.Controllers
{
  public class CompetitorsController : PNACController
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

    private bool CanEdit(Competitor competitor)
    {
      bool canEdit = false;

      if ((AspNetUser != null && AspNetUser.Admin) || (Competitor != null && Competitor.CompetitorId == competitor.CompetitorId))
        canEdit = true;

        return canEdit;
    }


    public ActionResult Edit(int id)
    {
      Competitor competitor = db.Competitors.SingleOrDefault(c => c.CompetitorId == id);
      CompetitorEdit edit = new CompetitorEdit();

      if (CanEdit(competitor))
      {

        edit.FirstName = competitor.FirstName;
        edit.NickName = competitor.NickName;
        edit.LastName = competitor.LastName;
        edit.Admin = competitor.AspNetUser.Admin;
        edit.CompetitorType = competitor.CompetitorType_;
        edit.Gender = competitor.Gender_;
        edit.CompetitorId = competitor.CompetitorId;
        edit.FriendlyName = competitor.FriendlyName();
      }
      else
        throw new NotImplementedException();

      return View(edit);
    }


    public ActionResult Index()
    {
      IEnumerable<Competitor> competitors = db.Competitors.OrderBy(c => c.LastName);
      CompetitorListItem competitorListItem;
      List<CompetitorListItem> list = new List<CompetitorListItem>();

      foreach (Competitor competitor in db.Competitors)
      {
        competitorListItem = new CompetitorListItem() { Name = competitor.FriendlyName(), CompetitorId = competitor.CompetitorId } ;

        if (CanEdit(competitor))
          competitorListItem.CanEdit = true;

        list.Add(competitorListItem);
      }

      return View(list);
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}