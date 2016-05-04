﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.Entities
{
  public class Catch
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int CompetitorId { get; set; }
    public virtual Competitor Competitor { get; set; }

    public int CompetitionId { get; set; }
    public virtual Competition Competition { get; set; }

    public int FishId { get; set; }
    public virtual Fish Fish { get; set; }

    [Required]
    public int Length { get; set; }

    [Required]
    public DateTime Recordered { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Catch()
    {
    }


    public Catch(Competitor competitor, Competition competition, Fish fish, int length)
    {
      CompetitorId = competitor.Id;
      Competitor = competitor;

      Competition = competition;
      CompetitionId = competition.Id;

      FishId = fish.Id;
      Fish = fish;

      Length = length;
      Recordered = DateTime.Now;
    }


    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
