using PNACCompetitions;
using PNACCompetitions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
  public class Tests
  {
    #region *********************** Constants ************************

    private CompetitionDbContext _context;

    private string BARCLAY = "Barclay";

    private string START_FYANS = "23 March 2016";

    private string END_FYANS = "25 March 2016";

    private string LAKE_FYANS = "Lake Fyans";


    private const string BROWN_TROUT = "Brown trout";
    private const string RAINBOW_TROUT = "Rainbow trout";
    private const string MURRAY_COD = "Murray Cod";
    private const string BREAM = "Bream";

    public double MAX_POWER = 16.51;//2 ^ 1.15 ^ 10


    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************
    #endregion


    #region *********************** Initialisation *******************

    public Tests(CompetitionDbContext context)
    {
      _context = context;
    }

    #endregion


    #region *********************** Methods **************************


    private void AddCatches(Club club)
    {
      DateTime dt = DateTime.Parse("24 March 2016 7:00pm");
      Competition competition = Manager.Get(_context, club, dt);

      AddCatchSaturday(club, competition);

      _context.Catches.Remove(_context.Catches.SingleOrDefault(c => c.Entry.CompetitionId == competition.CompetitionId && c.Entry.Competitor.LastName == "Deveson"));
      _context.SaveChanges();

      int no = _context.Catches.Where(c => c.Entry.CompetitionId == competition.CompetitionId).Count();

      if (no != 7)
        throw new Exception("AddCatch 10");

      Season season = Manager.GetSeason(_context, club, dt);

      //if (club.Seasons.SingleOrDefault(s => s.SeasonId == season.SeasonId).Competitions.SingleOrDefault(c => c.Venue == LAKE_FYANS) == null)
      //  throw new Exception("AddCatch 20");

      _context.Catches.RemoveRange(_context.Catches.Where(c => c.Entry.CompetitionId == competition.CompetitionId));
      _context.SaveChanges();

      AddCatchSaturday(club, competition);

      no = competition.Competitors.Count();

      if (no != 6)
        throw new Exception("AddCatch 30");
    }


    private void AddCatchSaturday(Club club, Competition competition)
    {
      AddCatchSaturdayDirect(club, competition);

      int no = Manager.Catches(_context, competition).Count();

      if (no != 8)
        throw new Exception("AddCatchSaturday 10");

      _context.Catches.RemoveRange(_context.Catches.Where(c => c.Entry.CompetitionId == competition.CompetitionId));
      _context.SaveChanges();

      if (Manager.Catches(_context, competition).Count() != 0)
        throw new Exception("AddCatchSaturday 20");

      AddCatchSaturdayDirect(club, competition);

      Catch catch1 = Manager.Catches(_context, competition).Where(c => c.Entry.Competitor.LastName == "Deveson").First();

      if (!(catch1.Entry.Competitor.LastName == "Deveson" && catch1.FishRule.Fish.Name == BROWN_TROUT && catch1.Length == 44))
        throw new Exception("AddCatchDirect 10");
    }


    private void AddCatchSaturdayDirect(Club club, Competition competition)
    {
      Season season = Manager.Get(_context, club, DateTime.Parse(START_FYANS), DateTime.Parse(END_FYANS));

      //if (@catch.PointsByFormula() - 142.69 > 0.01)
      //  throw new Exception("AddCatchSaturdayDirect");

      //  if (@catch.PointsByFormula() - 1000 > 0.01)
      //throw new Exception("AddCatchSaturdayDirect");

      AddEntries(club, "John", "Deveson", BROWN_TROUT, 44);
      AddEntries(club, "Rod", "King", BROWN_TROUT, 56);
      AddEntries(club, "", "Scott", BROWN_TROUT, 42);
      AddEntries(club, "Anthony", "Francis", BROWN_TROUT, 41);
      AddEntries(club, "", "Francis", RAINBOW_TROUT, 41);
      AddEntries(club, "", "Taylor", RAINBOW_TROUT, 36);

      AddEntries(club, "", "Brown", RAINBOW_TROUT, 36);
      AddEntries(club, "Rod", "King", RAINBOW_TROUT, 33);

    }


    private void AddEntries(Club club, string first, string last, string fishName, int length)
    {
      Competition competition = _context.Competitions.Single(c => c.ClubId == club.ClubId);

      Competitor competitor = null;

      if (string.IsNullOrWhiteSpace(first))
        competitor = _context.Competitors.Single(c => c.ClubId == club.ClubId && c.LastName == last);
      else
        competitor = _context.Competitors.Single(c => c.ClubId == club.ClubId && c.FirstName == first && c.LastName == last);

      Entry entry = null;

      entry = _context.Entries.SingleOrDefault(e => e.CompetitionId == competition.CompetitionId && e.CompetitorId == competitor.CompetitorId);

      if (entry == null)
      {
        entry = new Entry(competitor, competition);
        _context.Entries.Add(entry);
        _context.SaveChanges();
      }

      FishRule rule = _context.FishRules.Single(f => f.ClubId == club.ClubId && f.Fish.Name == fishName);

      Catch @catch = new Catch(entry, rule, length);
      _context.Catches.Add(@catch);
      _context.SaveChanges();
    }


    private Club AddClub()
    {
      string TEST_CLUB = "Preston Northcote Angling Club Test";
      Club test_club = _context.Clubs.SingleOrDefault(c => c.Name == TEST_CLUB);

      if (test_club != null)
      {
        _context.Clubs.RemoveRange(_context.Clubs.Where(c => c.Name == TEST_CLUB));
        _context.SaveChanges();
      }

      Club prestonNorthcote = new Club(TEST_CLUB);
      _context.Clubs.Add(prestonNorthcote);

      _context.SaveChanges();
      int clubId = prestonNorthcote.ClubId;

      if (_context.Clubs.SingleOrDefault(s => s.ClubId == clubId) == null)
        throw new Exception("AddClub 10");

      return prestonNorthcote;
    }


    private void AddCompetition(Club club)
    {
      Season season = Manager.Get(_context, club, DateTime.Parse(START_FYANS), DateTime.Parse(END_FYANS));

      Competition comp1 = new Competition(club, LAKE_FYANS, "Anazac weekend", DateTime.Parse("23 March 2016"), DateTime.Parse("25 March 2016"), ENVIRONMENT.FRESHWATER);
      _context.Competitions.Add(comp1);
      _context.SaveChanges();

      Competition competition = club.Competitions.First();
      if (competition.Venue != LAKE_FYANS)
        throw new Exception("AddCompetition 10");
    }


    private void AddCompetitors(Club club)
    {
      AddCompetitorsDirect(club);

      int no = _context.Competitors.Where(c => c.ClubId == club.ClubId && c.LastName == BARCLAY).Count();

      _context.Competitors.Remove(_context.Competitors.Where(c => c.ClubId == club.ClubId && c.LastName == "Patterson").First());
      _context.SaveChanges();
      _context.Competitors.Remove(_context.Competitors.Where(c => c.ClubId == club.ClubId && c.LastName == BARCLAY).First());
      _context.SaveChanges();
      _context.Competitors.Remove(_context.Competitors.Where(c => c.ClubId == club.ClubId && c.LastName == "Mallini").First());
      _context.SaveChanges();

      if (_context.Competitors.SingleOrDefault(c => c.ClubId == club.ClubId && c.LastName == BARCLAY) != null)
        throw new Exception("AddCompetitors 5");

      if (club.Competitors.Count() != 8)
        throw new Exception("AddCompetitors 10");

      if (club.Seasons.Count() != 3)
        throw new Exception("AddCompetitors 20");

      if (_context.Fish.Count() != 4)
        throw new Exception("AddCompetitors 30");

      _context.Competitors.RemoveRange(club.Competitors);
      _context.SaveChanges();

      if (club.Competitors.Count() != 0)
        throw new Exception("AddCompetitors 40");

      AddCompetitorsDirect(club);

    }


    private void AddCompetitorsDirect(Club club)
    {
      Competitor competitor1 = new Competitor("Peter", "Swampy", "Patterson", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor1);
      Competitor competitor2 = new Competitor("Eden", "", "Mallini", club, Competitor.COMPETITOR_TYPE.JUNIOR, Competitor.GENDER.FEMALE);
      _context.Competitors.Add(competitor2);
      Competitor competitor3 = new Competitor("Andrew", "MadDog", BARCLAY, club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor3);
      Competitor competitor4 = new Competitor("John", "", "Deveson", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor4);
      Competitor competitor5 = new Competitor("Gordon", "Flash", "McDonald", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor5);
      Competitor competitor6 = new Competitor("Len", "", "Brown", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor6);
      Competitor competitor7 = new Competitor("Rod", "", "King", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor7);
      Competitor competitor8 = new Competitor("Jason", "", "King", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor8);
      Competitor competitor9 = new Competitor("C", "", "Scott", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor9);
      Competitor competitor10 = new Competitor("Anthony", "Mr Laursiton", "Francis", club, Competitor.COMPETITOR_TYPE.NON_MEMBER, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor10);
      Competitor competitor11 = new Competitor("Stuart", "", "Taylor", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Competitors.Add(competitor11);

      _context.SaveChanges();

      int count = _context.Clubs.Single(c => c.ClubId == club.ClubId).Competitors.Count();

      //IEnumerable<Competitor> competitors = _context.Competitors;
      int no = _context.Clubs.Single(c => c.ClubId == club.ClubId).Competitors.Count();

      if (_context.Clubs.Single(c => c.ClubId == club.ClubId).Competitors.Count() != 11)
        throw new Exception("AddCompetitors 10");

      int competitor1Id = _context.Clubs.Single(c => c.ClubId == club.ClubId).Competitors.First().CompetitorId;
      int competitor2Id = _context.Clubs.Single(c => c.ClubId == club.ClubId).Competitors.Skip(1).First().CompetitorId;

      int no1 = _context.Competitors.Where(c => c.ClubId == club.ClubId).Count();

      if (no != 11)
        throw new Exception("AddCompetitors 20");

      if (_context.Competitors.SingleOrDefault(c => c.CompetitorId == competitor1Id) == null)
        throw new Exception("AddCompetitors 30");

      if (_context.Competitors.SingleOrDefault(c => c.CompetitorId == competitor2Id) == null)
        throw new Exception("AddCompetitors 40");
    }



    private void AddFish(Club club)
    {
      AddFishDirect(club);

      if (_context.Fish.Count() != 4)
        throw new Exception("AddFish 10");

      _context.Fish.RemoveRange(_context.Fish);
      _context.SaveChanges();

      if (_context.Fish.Count() != 0)
        throw new Exception("AddFish 20");

      AddFishDirect(club);

      if (_context.Fish.Count() != 4)
        throw new Exception("AddFish 30");

    }


    private void AddFishDirect(Club club)
    {
      Fish fish1 = new Fish("Brown trout", ENVIRONMENT.FRESHWATER);
      Fish fish2 = new Fish("Rainbow trout", ENVIRONMENT.FRESHWATER);
      Fish fish3 = new Fish("Murray cod", ENVIRONMENT.FRESHWATER);
      Fish fish4 = new Fish("Bream", ENVIRONMENT.ALL);

      if (!_context.Fish.Any(f => f.Name == fish1.Name))
        _context.Fish.Add(fish1);
      else
        fish1 = _context.Fish.Single(f => f.Name == fish1.Name);

      if (!_context.Fish.Any(f => f.Name == fish2.Name))
        _context.Fish.Add(fish2);
      else
        fish2 = _context.Fish.Single(f => f.Name == fish1.Name);

      if (!_context.Fish.Any(f => f.Name == fish3.Name))
        _context.Fish.Add(fish3);
      else
        fish3 = _context.Fish.Single(f => f.Name == fish1.Name);

      if (!_context.Fish.Any(f => f.Name == fish4.Name))
        _context.Fish.Add(fish4);
      else
        fish4 = _context.Fish.Single(f => f.Name == fish1.Name);

      _context.SaveChanges();

      FishRule rule1 = new FishRule(fish1, club, 85, 28, 1);
      _context.FishRules.Add(rule1);
      FishRule rule2 = new FishRule(fish2, club, 85, 28, 1);
      _context.FishRules.Add(rule2);
      FishRule rule3 = new FishRule(fish3, club, 120, 45, 1);
      _context.FishRules.Add(rule3);
      FishRule rule4 = new FishRule(fish4, club, 45, 28, 1);
      _context.FishRules.Add(rule4);

      _context.SaveChanges();
    }


    private void AddSeasons(Club club)
    {
      AddSeasonsDirect(club);

      if (club.Seasons.Count() != 3)
        throw new Exception("AddSeasons 2");

      _context.Seasons.RemoveRange(_context.Seasons.Where(s => s.ClubId == club.ClubId));
      _context.SaveChanges();

      if (club.Seasons.Count() != 0)
        throw new Exception("AddSeasons 5");

      AddSeasonsDirect(club);

      IEnumerable<Season> seasons = _context.Seasons;
      int no = seasons.Count();

      if (_context.Clubs.Single(c => c.ClubId == club.ClubId).Seasons.Count() != 3)
        throw new Exception("AddSeasons 10");

      if (_context.Seasons.Where(s => s.ClubId == club.ClubId).Count() != 3)
        throw new Exception("AddSeasons 20");
    }

    private void AddSeasonsDirect(Club club)
    {
      Season season1 = new Season(club, DateTime.Parse("5 September 2015"), DateTime.Parse("5 September 2016"));
      _context.Seasons.Add(season1);

      Season season2 = new Season(club, DateTime.Parse("5 September 2016"), DateTime.Parse("5 September 2017"));
      _context.Seasons.Add(season2);

      Season season3 = new Season(club, DateTime.Parse("5 September 2017"), DateTime.Parse("5 September 2018"));
      _context.Seasons.Add(season3);

      _context.SaveChanges();
    }


    public void Construction(bool delete)
    {
      Club club = AddClub();

      AddFish(club);
      int clubId = club.ClubId;

      AddSeasons(club);

      int season1Id = club.Seasons.First().SeasonId;
      int season2Id = club.Seasons.Skip(1).First().SeasonId;

      AddCompetition(club);
      AddCompetitors(club);
      AddCatches(club);

      _context.Competitors.RemoveRange(club.Competitors);
      _context.Competitions.RemoveRange(club.Competitions);
      _context.SaveChanges();

      if(club.Competitions.Count() != 0)
        throw new Exception("Construction 10");

      if (club.Competitors.Count() != 0)
        throw new Exception("Construction 20");

      if (_context.Catches.Count() != 0)
        throw new Exception("Construction 30");

      AddCompetition(club);
      AddCompetitors(club);
      AddCatches(club);

      IEnumerable<Competition> competitions = club.Competitions;
      IEnumerable<Catch> catches = Manager.Catches(_context, club.Competitions.First());

      int no = catches.Count();

      if (catches.Count() != 8)
        throw new Exception("Construction 5");


      if(delete)
      {
        Competitor competitor = club.Competitors.Single(c => c.LastName == "Taylor");
        _context.Competitors.Remove(competitor);
        _context.SaveChanges();

        _context.Competitors.RemoveRange(club.Competitors);
        _context.SaveChanges();

        _context.Clubs.Remove(club);
        _context.SaveChanges();

        if (_context.Seasons.SingleOrDefault(s => s.SeasonId == season1Id) != null)
          throw new Exception("Construction 10");

        if (_context.Seasons.SingleOrDefault(s => s.SeasonId == season2Id) != null)
          throw new Exception("Construction 20");

        if (_context.Competitors.SingleOrDefault(c => c.ClubId == clubId) != null)
          throw new Exception("Construction 30");
      }
    }


    public void Power()
    {
      double x = Catch.PowerN(1);
      if (x - 2.21 > 0.01)
        throw new Exception("Power 10");

      x = Catch.PowerN(2);
      if (x - 2.50 > 0.01)
        throw new Exception("Power 20");

      x = Catch.PowerN(9.5);
      if (x - 13.66 > 0.01)
        throw new Exception("Power 30");

      x = Catch.PowerN(10);
      if (x - MAX_POWER > 0.01)
        throw new Exception("Power 40");
    }


    #endregion



  }
}
