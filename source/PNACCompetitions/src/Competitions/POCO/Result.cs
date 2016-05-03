using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.POCO
{
  public class Result
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************

    public int CompetitorId { get; set; }
    public Competitor Competitor { get; set; }

    public int CompetitionId { get; set; }
    public Competition Competition { get; set; }

    public int FishId { get; set; }
    public Fish Fish { get; set; }

    [Required]
    public int Length { get; set; }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
