using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNACCompetitions.Entities
{
  public class Season
  {

    #region *********************** Constants ************************

    public enum COMPETITOR_TYPE { UNASSIGNED, NON_MEMBER, SENIOR, JUNIOR }

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int ClubId { get; set; }
    public virtual Club Club { get; set; }

    public int SeasonId { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime End { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime Start { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Season()
    {
    }


    public Season(Club club, DateTime start, DateTime end)
    {
      if (end < start)
        throw new Exception("Season(Club club, DateTime start, DateTime end) - end must be after start");

      Club = club;
      ClubId = club.ClubId;

      Start = start;
      End = end;
    }

    #endregion


    #region *********************** Methods **************************


    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}
