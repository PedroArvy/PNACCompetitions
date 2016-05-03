using System;
using System.ComponentModel.DataAnnotations;


namespace Competitions.POCO
{
  public class Season
  {

    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int Id { get; set; }

    [Required]
    public DateTime End { get; set; }

    [Required]
    public DateTime Start { get; set; }
    
    #endregion


    #region *********************** Initialisation *******************
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion



  }
}
