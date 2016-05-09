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

    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************


    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}