using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PNACCompetitions.Entities
{
  public class Fish
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int FishId { get; set; }

    [MaxLength(100)]
    [Column(TypeName = "varchar"), Required]
    public string Name { get; set; }

    public List<FishRule> FishRules { get; set; }

    public ENVIRONMENT Environment { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Fish()
    {
    }


    public Fish(string name, int maximum, int minimum, double difficulty, ENVIRONMENT environment)
    {
      //FishClubId = fishClub.FishClubId;

      Name = name;
      Environment = environment;

    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
