using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Competitions
{
  // This project can output the Class library as a NuGet Package.
  // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
  public class Competition
  {
    public int Id { get; set; }

    public DateTime End { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<Competitions.POCO.Result> Results { get; set; }

    [Required]
    public DateTime Start { get; set; }

    public Competition()
    {
    }

  }
}
