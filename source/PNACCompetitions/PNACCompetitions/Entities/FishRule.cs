using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNACCompetitions.Entities
{
  public class FishRule
  {
  
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int FishRuleId { get; set; }

    public int ClubId { get; set; }
    public virtual Club Club { get; set; }

    public int FishId { get; set; }
    public virtual Fish Fish { get; set; }

    public List<Catch> Catches { get; set; }

    [Required]
    public double Difficulty { get; set; }

    [Required]
    public int Maximum { get; set; }

    [Required]
    public int Minimum { get; set; }

    #endregion


    #region *********************** Initialisation *******************



    public FishRule()
    {
    }

    public FishRule(Fish fish, Club club, int maximum, int minimum, double difficulty)
    {
      Fish = fish;
      FishId = fish.FishId;

      Club = club;
      ClubId = club.ClubId;

      Maximum = maximum;
      Minimum = minimum;
      Difficulty = difficulty;
    }


    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}