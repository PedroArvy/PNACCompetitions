using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competitions.POCO
{
  public class Fish
  {
    [Required]
    public int Difficulty { get; set; }

    public int Id { get; set; }

    [Required]
    public int Maximum { get; set; }

    [Required]
    public int Minimum { get; set; }

    [Required]
    public string Name { get; set; }

  }
}
