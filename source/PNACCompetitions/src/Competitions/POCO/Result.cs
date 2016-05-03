using System.ComponentModel.DataAnnotations;

namespace Competitions.POCO
{
  public class Result
  {
    public int Id { get; set; }

    public int CompetitorId { get; set; }
    public Competition Competitor { get; set; }

    public int CompetitionId { get; set; }
    public Competition Competition { get; set; }

    public int FishId { get; set; }
    public Fish Fish { get; set; }

    [Required]
    public int Length { get; set; }
  }
}
