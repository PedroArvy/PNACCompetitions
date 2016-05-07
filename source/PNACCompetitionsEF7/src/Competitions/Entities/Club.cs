using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.Entities
{
  public class Club
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int ClubId { get; set; }

    public List<Competition> Competitions { get; set; }

    //3
    public List<Competitor> Competitors { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string Name { get; set; }

    public List<Season> Seasons { get; set; }

    public List<Fish> Fish { get; set; }

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
