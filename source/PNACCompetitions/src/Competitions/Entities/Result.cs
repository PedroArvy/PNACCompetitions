﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.Entities
{
  public class Result
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int CompetitorId { get; set; }
    public Competitor Competitor { get; set; }

    public int CompetitionId { get; set; }
    public Competition Competition { get; set; }

    public int FishId { get; set; }
    public Fish Fish { get; set; }

    [Required]
    public int Length { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Result()
    {
    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
