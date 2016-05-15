using Microsoft.AspNet.Identity.Owin;
using PNACCompetitionsDbFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PNACCompetitionsDbFirst.Controllers
{
  public class PNACController : Controller
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************

    private AspNetUser _AspNetUser = null;
    private Competitor _Competitor = null;
    private ApplicationSignInManager _signInManager;
    protected ApplicationUserManager _userManager;

    protected PNACCompetitionsEntities db = new PNACCompetitionsEntities();

    #endregion


    #region *********************** Properties ***********************

    /// <summary>
    /// The logged in AspNetUser
    /// </summary>
    protected AspNetUser AspNetUser
    {
      get
      {
        if (_AspNetUser == null)
        {
          if (User != null)
          {
            _AspNetUser = db.AspNetUsers.SingleOrDefault(a => a.Email == User.Identity.Name);
          }
        }

        return _AspNetUser;
      }
    }


    /// <summary>
    /// The logged in Competitor
    /// </summary>    
    protected Competitor Competitor
    {
      get
      {
        if (AspNetUser != null && _Competitor == null)
          _Competitor = db.Competitors.SingleOrDefault(c => c.AspNetUserId == AspNetUser.Id);

        return _Competitor;
      }
    }


    protected bool IsAdmin
    {
      get
      {
        bool isAdmin = false;

        if (Competitor != null && Competitor.Admin)
          isAdmin = true;

        return isAdmin;
      }
    }


    public ApplicationSignInManager SignInManager
    {
      get
      {
        return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
      }
      private set
      {
        _signInManager = value;
      }
    }


    protected ApplicationUserManager UserManager
    {
      get
      {
        return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
      }
      set
      {
        _userManager = value;
      }
    }

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************


    protected string MakeNames()
    {
      string list = "";
      int count = 0;
      string name;

      List<string> names = new List<string>();

      foreach (Competitor competitor in db.Competitors.OrderBy(c => c.LastName).ThenBy(c => c.FirstName))
      {
        name = competitor.FriendlyName().Replace("\"", "");

        if (count > 0)
          list += ",\n";

        list += "{ label: \"" +  name + "\", value: \"" + competitor.CompetitorId + "\" }";
        count++;
      }

      return list;
    }


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}