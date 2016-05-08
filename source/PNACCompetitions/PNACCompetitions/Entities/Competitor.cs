using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PNACCompetitions.Entities
{

  public class Competitor //: IdentityUser
  {
    #region *********************** Constants ************************

    public enum COMPETITOR_TYPE { UNASSIGNED, NON_MEMBER, JUNIOR, SENIOR }

    public enum GENDER { UNKNOWN, MALE, FEMALE }

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    /// <summary>
    /// Distinct competitions
    /// </summary>
    [NotMapped]
    public List<Competition> Competitions
    {
      get
      {
        List<Competition> competitions = new List<Competition>();

        if(Entries != null)
        {
          foreach (Entry entry in Entries)
          {
            if (!competitions.Contains(entry.Competition))
              competitions.Add(entry.Competition);
          }
        }

        return competitions;
      }
    }
    

    public COMPETITOR_TYPE CompetitorType { get; set; }

    public virtual List<Entry> Entries { get; set; }

    public GENDER Gender { get; set; }

    public int CompetitorId { get; set; }

    public int ClubId { get; set; }
    [ForeignKey("ClubId")]
    public virtual Club Club { get; set; }


    [MaxLength(100)]
    [Column(TypeName = "varchar"), Required]
    public string FirstName { get; set; }


    [MaxLength(100)]
    [Column(TypeName = "varchar"), Required]
    public string LastName { get; set; }


    [MaxLength(100)]
    [Column(TypeName = "varchar")]
    public string NickName { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Competitor()
    {
    }


    public Competitor(string firstname, string nickname, string lastname, Club club, COMPETITOR_TYPE competitorType, GENDER gender)
    {
      ClubId = club.ClubId;
      Club = club;
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
