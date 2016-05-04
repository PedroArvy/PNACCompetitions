using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Competitions.POCO
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

    [Column(TypeName = "smalldatetime"), Required]
    public DateTime End { get; set; }

    [Column(TypeName = "smalldatetime"), Required]
    public DateTime Start { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Season()
    {
    }

    #endregion


    #region *********************** Methods **************************



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


    #region *********************** Interfaces ***********************
    #endregion



  }
}
