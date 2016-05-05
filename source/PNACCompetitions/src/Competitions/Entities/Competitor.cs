using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.Entities
{

  public class Competitor
  {
    #region *********************** Constants ************************

    public enum COMPETITOR_TYPE { UNASSIGNED, NON_MEMBER, JUNIOR, SENIOR}

    public enum GENDER { UNKNOWN, MALE, FEMALE }

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int ClubId { get; set; }
    public Club  Club { get; set; }

    public COMPETITOR_TYPE CompetitorType { get; set; }

    public List<Catch> Catches { get; set; }

    public GENDER Gender { get; set; }

    public int CompetitorId { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string FirstName { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string LastName { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string NickName { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Competitor()
    {
    }


    public Competitor(string firstname, string nickname, string lastname, Club club, COMPETITOR_TYPE competitorType, GENDER gender)
    {
      if(club != null)
      {
        Club = club;
        ClubId = club.ClubId;
      }

      CompetitorType = competitorType;
      Gender = gender;
      FirstName = firstname;
      LastName = lastname;
      NickName = nickname;
    }

    #endregion


    #region *********************** Methods **************************



    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
