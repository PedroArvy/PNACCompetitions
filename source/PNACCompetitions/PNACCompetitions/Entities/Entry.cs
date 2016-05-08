using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PNACCompetitions.Entities
{
  public class Entry
  {

    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int EntryId { get; set; }

    public virtual List<Catch> Catches { get; set; }

    public int CompetitorId { get; set; }
    public virtual Competitor Competitor { get; set; }

    public int CompetitionId { get; set; }
    public virtual Competition Competition { get; set; }

    #endregion


    #region *********************** Initialisation *******************


    public Entry()
    {
    }


    public Entry(Competitor competitor, Competition competition)
    {
      Competitor = competitor;
      CompetitorId = competitor.CompetitorId;
      Competition = competition;
      CompetitionId = competition.CompetitionId;
    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}