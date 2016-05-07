using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public int CompetitorId { get; set; }
    [Required]
    public virtual Competitor Competitor { get; set; }

    public int CompetitionId { get; set; }
    [Required]
    public virtual Competition Competition { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Entry()
    {
    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}