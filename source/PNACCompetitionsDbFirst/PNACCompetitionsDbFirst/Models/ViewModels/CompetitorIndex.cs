using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class CompetitorIndex
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public bool CanCreate { get; set; }

    public List<CompetitorListItem> CompetitorListItems { get; set; }

    public string MemberNames { get; set; }


    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************

    public string NameToDisplay(CompetitorListItem competitor)
    {
      string name = competitor.Name;

      if (competitor.Hide)
        name += " (hidden)";

      return name;
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}