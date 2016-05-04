using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Competitions.Entities
{
  public class Fish
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int ClubId { get; set; }
    public Club Club { get; set; }

    [Required]
    public double Difficulty { get; set; }

    public int Id { get; set; }

    [Required]
    public int Maximum { get; set; }

    [Required]
    public int Minimum { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string Name { get; set; }

    public List<Result> Results { get; set; }

    public ENVIRONMENT Environment { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Fish()
    {
    }


    public Fish(Club club, string name, int maximum, int minimum, double difficulty, ENVIRONMENT environment)
    {
      ClubId = club.Id;

      Name = name;
      Maximum = maximum;
      Minimum = minimum;
      Difficulty = difficulty;
      Environment = environment;

    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
