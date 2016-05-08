using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PNACCompetitions.Entities
{
  public class Club
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int ClubId { get; set; }


    public virtual List<Competitor> Competitors { get; set; }


    public List<Competition> Competitions { get; set; }//1


    public List<FishRule> FishRule { get; set; }

    [MaxLength(100)]
    [Column(TypeName = "varchar"), Required]
    public string Name { get; set; }

    public List<Season> Seasons { get; set; }

    #endregion


    #region *********************** Initialisation *******************


    public Club()
    {
    }


    public Club(string name)
    {
      Name = name;
    }

    #endregion


    #region *********************** Methods **************************


    #endregion


    #region *********************** Interfaces ***********************
    #endregion

  }
}
