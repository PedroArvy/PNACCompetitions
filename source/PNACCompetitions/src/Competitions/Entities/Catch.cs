using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Competitions.Entities
{
  public class Catch
  {
    #region *********************** Constants ************************

    private const double BASE_POINTS = 100;
    private const double FACTOR = 1.15;
    private const double MAXIMUM_POINTS = 1000;
    public const double MAX_POWER = 16.5133;

    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int CatchId { get; set; }

    public bool Cleaned { get; set; }

    public int CompetitorId { get; set; }
    public Competitor Competitor { get; set; }

    public int CompetitionId { get; set; }
    public Competition Competition { get; set; }

    public int FishId { get; set; }
    public Fish Fish { get; set; }

    [Required]
    public int Length { get; set; }

    [Required]
    public DateTime Recordered { get; set; }

    public double Weight { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Catch()
    {
    }


    public Catch(Competitor competitor, Competition competition, Fish fish, int length)
    {
      CompetitorId = competitor.CompetitorId;
      Competitor = competitor;

      Competition = competition;
      CompetitionId = competition.CompetitionId;

      FishId = fish.FishId;
      Fish = fish;

      Length = length;
      Recordered = DateTime.Now;
    }


    public Catch(Fish fish, int length)
    {
      FishId = fish.FishId;
      Fish = fish;

      Length = length;
      Recordered = DateTime.Now;
    }

    #endregion


    #region *********************** Methods **************************


    public double CompetitionWeight()
    {
      if (Cleaned)
        return Weight;
      else
        return 0.9 * Weight;
    }


    public double PointsByFormula()
    {
      double value = 0;

      if(Length > Fish.Minimum)
      {
        double @base = Fish.Difficulty * BASE_POINTS;
        double percentageToMax = (double)(Length - Fish.Minimum) / (double)(Fish.Maximum - Fish.Minimum);
        double two_power_size = PowerN(percentageToMax * 10);

        value = @base + (MAXIMUM_POINTS - @base) * percentageToMax * two_power_size / MAX_POWER;

        value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
      }


      return value;
    }


    public double PointsByLengthOriginal()
    {
      double value = 0;

      if (Length > Fish.Minimum)
        value = 5 + Length - Fish.Minimum;

      return value;
    }


    public static double PowerN(double n)
    {
      return Math.Pow(2, Math.Pow(FACTOR, n));
    }

    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
