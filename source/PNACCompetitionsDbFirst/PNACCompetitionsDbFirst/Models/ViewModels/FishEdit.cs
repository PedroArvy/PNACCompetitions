using System.ComponentModel.DataAnnotations;


namespace PNACCompetitionsDbFirst.Models.ViewModels
{
  public class FishEdit
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************


    public int FishId { get; set; }


    [Required]
    [Range(1, 100)]
    public double Difficulty { get; set; }


    public bool EnvironmentFreshwater { get; set; }
    public bool EnvironmentEstuary { get; set; }
    public bool EnvironmentSaltwater { get; set; }


    [Required]
    public string Name { get; set; }


    //[Required]
    //[Range(20, 2000)]
    //public int Maximum { get; set; }


    [Required]
    [Range(20, 2000)]
    public int Minimum { get; set; }

    
    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion
  }
}