using Competitions.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Competitions
{
  // This project can output the Class library as a NuGet Package.
  // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
  public class Competition
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public int Id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? End { get; set; }

    [Column(TypeName = "varchar(100)"), Required]
    public string Name { get; set; }

    [Column(TypeName = "smalldatetime"), Required]
    public DateTime Start { get; set; }

    //many to many
    public List<CompetitorCompetition> CompetitorCompetitions { get; set; }

    //public int Referee1Id { get; set; }
    //public Competitor Referee1 { get; set; }

    //public int Referee2Id { get; set; }
    //public Competitor Referee2 { get; set; }

    public List<Result> Results { get; set; }

    public int TripCaptainId { get; set; }
    public Competitor TripCaptain { get; set; }


    #endregion


    #region *********************** Initialisation *******************

    public Competition()
    {
    }

    #endregion


    #region *********************** Methods **************************
    #endregion


    #region *********************** Interfaces ***********************
    #endregion





  }
}
