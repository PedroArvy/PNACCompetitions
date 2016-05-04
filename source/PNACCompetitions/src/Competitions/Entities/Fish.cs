using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Competitions.POCO
{
  public class Fish
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************


    [Required]
    public int Difficulty { get; set; }

    public int Id { get; set; }

    [Required]
    public int Maximum { get; set; }

    [Required]
    public int Minimum { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string Name { get; set; }

    public List<Result> Results { get; set; }


    #endregion


    #region *********************** Initialisation *******************

    public Fish()
    {

    }
    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion


  }
}
