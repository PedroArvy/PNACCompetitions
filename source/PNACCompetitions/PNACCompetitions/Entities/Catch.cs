using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNACCompetitions.Entities
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

    public int EntryId { get; set; }
    [Required]
    public virtual Entry Entry { get; set; }


    public int FishRuleId { get; set; }
    [Required]
    public virtual FishRule FishRule { get; set; }


    [Required]
    public int Length { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime Recordered { get; set; }

    public double Weight { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Catch()
    {
    }


    public Catch(Entry entry, FishRule fishRule, int length)
    {
      EntryId = entry.EntryId;
      Entry = entry;

     FishRuleId = fishRule.FishId;
      FishRule = fishRule;

      Length = length;
      Recordered = DateTime.Now;
    }


    public Catch(FishRule fishRule, int length)
    {
      //FishRuleId = fishRule.FishId;
     // FishRule = fishRule;

      //Length = length;
     // Recordered = DateTime.Now;
    }

    #endregion


    #region *********************** Methods **************************


    public double CompetitionWeight()
    {
      //if (Cleaned)
      // return Weight;
      //else
      // return 0.9 * Weight;
      return 1;
    }


    public double PointsByFormula()
    {
      double value = 0;

      /*
      if(Length > Fish.Minimum)
      {
        double @base = Fish.Difficulty * BASE_POINTS;
        double percentageToMax = (double)(Length - Fish.Minimum) / (double)(Fish.Maximum - Fish.Minimum);
        double two_power_size = PowerN(percentageToMax * 10);

        value = @base + (MAXIMUM_POINTS - @base) * percentageToMax * two_power_size / MAX_POWER;

        value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
      }
      */

      return value;
    }


    public double PointsByLengthOriginal()
    {
      double value = 0;

     // if (Length > Fish.Minimum)
      //  value = 5 + Length - Fish.Minimum;

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
