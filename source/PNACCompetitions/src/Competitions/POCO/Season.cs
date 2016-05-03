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

    public COMPETITOR_TYPE CompetitorType { get; set; }

    public int Id { get; set; }

    [Column(TypeName = "smalldatetime"), Required]
    public DateTime End { get; set; }

    [Column(TypeName = "smalldatetime"), Required]
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
