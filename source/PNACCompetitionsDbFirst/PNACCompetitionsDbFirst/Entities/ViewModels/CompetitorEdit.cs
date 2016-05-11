﻿using System.ComponentModel.DataAnnotations;


namespace PNACCompetitionsDbFirst.Entities.ViewModels
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
    public double Difficulty { get; set; }


    [Required]
    public string Name { get; set; }


    [Required]
    public int Maximum { get; set; }


    [Required]
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