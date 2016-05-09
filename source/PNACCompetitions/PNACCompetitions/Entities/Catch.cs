using PNACCompetitions.Entities.ViewModel;
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


    [NotMapped]
    public Competitor Competitor
    {
      get
      {
        return Entry.Competitor;
      }
    }


    public int EntryId { get; set; }
    public virtual Entry Entry { get; set; }


    public int FishRuleId { get; set; }
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
      FishRuleId = fishRule.FishId;
      FishRule = fishRule;

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


    public Score LeaderBoard()
    {
      Score board = new Score();
      board.Name = Competitor.FriendlyName();
      board.FormulaPoints = FormulaPoints();
      board.TrialPoints = TrialPoints();

      return board;
    }


    public double FormulaPoints()
    {
      double value = 0;


      if (Length > FishRule.Minimum)
      {
        double @base = FishRule.Difficulty * BASE_POINTS;
        double percentageToMax = (double)(Length - FishRule.Minimum) / (double)(FishRule.Maximum - FishRule.Minimum);
        double two_power_size = PowerN(percentageToMax * 10);

        value = @base + (MAXIMUM_POINTS - @base) * percentageToMax * two_power_size / MAX_POWER;

        value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
      }


      return value;
    }


    public int TrialPoints()
    {
      int value = 0;

      if (Length > FishRule.Minimum)
        value = 5 + Length - FishRule.Minimum;

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
