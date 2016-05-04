
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Competitions.Entities
{
  public class Season
  {

    #region *********************** Constants ************************

    public enum COMPETITOR_TYPE { UNASSIGNED, NON_MEMBER, SENIOR, JUNIOR}

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int ClubId { get; set; }
    public Club Club { get; set; }

    public int Id { get; set; }

    [Required]
    public DateTime End { get; set; }

    [Required]
    public DateTime Start { get; set; }

    public List<Competition> Competitions { get; set; }

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
      ClubId = club.Id;

      Start = start;
      End = end;
    }

    #endregion


    #region *********************** Methods **************************

    public static Season Get(CompetitionDbContext context, Club club, DateTime start, DateTime end)
    {
      Season season = null;

      season = context.Seasons.SingleOrDefault(s => s.ClubId == club.Id && s.Start <= start && end <= s.End);

      return season;
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}
