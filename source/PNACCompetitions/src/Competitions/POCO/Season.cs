using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competitions.POCO
{
  public class Season
  {
    public int Id { get; set; }

    [Required]
    public DateTime End { get; set; }

    [Required]
    public DateTime Start { get; set; }

  }
}
