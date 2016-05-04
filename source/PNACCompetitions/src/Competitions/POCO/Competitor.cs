using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competitions.POCO
{

  public class Competitor
  {
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public string NickName { get; set; }

    public ICollection<Result> Results { get; set; }

  }
}
