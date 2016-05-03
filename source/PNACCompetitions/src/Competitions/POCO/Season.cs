using System;
using System.ComponentModel.DataAnnotations;


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
