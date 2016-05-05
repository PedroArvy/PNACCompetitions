using Competitions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Competitions.Tests
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

      _context.Catches.Remove(_context.Catches.SingleOrDefault(c => c.CompetitionId == competition.CompetitionId && c.Competitor.LastName == "Deveson"));
      _context.SaveChanges();

      if (_context.Catches.Where(c => c.CompetitionId == competition.CompetitionId).Count() != 6)
        throw new Exception("AddCatch 10");

      Season season = Manager.GetSeason(_context, club, dt);

      if (club.Seasons.SingleOrDefault(s => s.SeasonId == season.SeasonId).Competitions.SingleOrDefault(c => c.Venue == LAKE_FYANS) == null)
        throw new Exception("AddCatch 20");

      _context.Catches.RemoveRange(_context.Catches.Where(c => c.CompetitionId == competition.CompetitionId));
      _context.SaveChanges();

      AddCatchSaturday(club, competition);
    }


    private void AddCatchSaturday(Club club, Competition competition)
    {
      AddCatchSaturdayDirect(club, competition);

      if (competition.Catches.Count() != 7)
        throw new Exception("AddCatchSaturday 10");

      _context.Catches.RemoveRange(_context.Catches.Where(c => c.CompetitionId == competition.CompetitionId));
      _context.SaveChanges();

      if (competition.Catches.Count() != 0)
        throw new Exception("AddCatchSaturday 20");

      AddCatchSaturdayDirect(club, competition);

      Catch catch1 = _context.Competitions.SingleOrDefault(c => c.CompetitionId == competition.CompetitionId).Catches.Where(c => c.Competitor.LastName == "Deveson").First();

      if (!(catch1.Competitor.LastName == "Deveson" && catch1.Fish.Name == BROWN_TROUT && catch1.Length == 44))
        throw new Exception("AddCatchDirect 10");
    }


    private void AddCatchSaturdayDirect(Club club, Competition competition)
    {
      Season season = Manager.Get(_context, club, DateTime.Parse(START_FYANS), DateTime.Parse(END_FYANS));
      Catch @catch;

      int no = club.Competitors.Where(c => c.LastName == BARCLAY).Count();

      @catch = new Catch(club.Competitors.Single(c => c.LastName == "Deveson"), competition, _context.Fish.Single(f => f.ClubId == club.ClubId && f.Name == BROWN_TROUT), 44);
      _context.Add(@catch);

      if (@catch.PointsByFormula() - 142.69 > 0.01)
        throw new Exception("AddCatchSaturdayDirect");

      @catch = new Catch(_context.Fish.Single(f => f.ClubId == club.ClubId && f.Name == BROWN_TROUT), 85);

      if (@catch.PointsByFormula() - 1000 > 0.01)
        throw new Exception("AddCatchSaturdayDirect");

      @catch = new Catch(club.Competitors.Single(c => c.FirstName == "Rod" && c.LastName == "King"), competition, _context.Fish.Single(f => f.ClubId == club.ClubId && f.Name == BROWN_TROUT), 56);
      _context.Add(@catch);

      @catch = new Catch(club.Competitors.Single(c => c.LastName == "Scott"), competition, _context.Fish.Single(f => f.ClubId == club.ClubId && f.Name == BROWN_TROUT), 42);
      _context.Add(@catch);

      @catch = new Catch(club.Competitors.Single(c => c.LastName == "Francis"), competition, _context.Fish.Single(f => f.ClubId == club.ClubId && f.Name == BROWN_TROUT), 41);
      _context.Add(@catch);

      @catch = new Catch(club.Competitors.Single(c => c.LastName == "Taylor"), competition, _context.Fish.Single(f => f.ClubId == club.ClubId && f.Name == RAINBOW_TROUT), 36);
      _context.Add(@catch);

      @catch = new Catch(club.Competitors.Single(c => c.LastName == "Brown"), competition, _context.Fish.Single(f => f.ClubId == club.ClubId && f.Name == RAINBOW_TROUT), 36);
      _context.Add(@catch);

      Competitor competitor = club.Competitors.Single(c => c.FirstName == "Rod" && c.LastName == "King");
      _context.Add(new Catch(competitor, competition, _context.Fish.Single(f => f.ClubId == club.ClubId && f.Name == RAINBOW_TROUT), 33));

      _context.SaveChanges();
    }


    private Club AddClub()
    {
      _context.Clubs.RemoveRange(_context.Clubs);
      _context.SaveChanges();

      Club prestonNorthcote = new Club("Northern Suburbs Fly Fishing Club");
      _context.Add(prestonNorthcote);

      _context.SaveChanges();
      int clubId = prestonNorthcote.ClubId;

      if (_context.Clubs.SingleOrDefault(s => s.ClubId == clubId) == null)
        throw new Exception("AddClub 10");

      return prestonNorthcote;
    }


    private void AddCompetition(Club club)
    {
      Season season = Manager.Get(_context, club, DateTime.Parse(START_FYANS), DateTime.Parse(END_FYANS));

      Competition comp1 = new Competition(club, LAKE_FYANS, "Anazac weekend", DateTime.Parse("23 March 2016"), DateTime.Parse("25 March 2016"), ENVIRONMENT.FRESHWATER, season);
      _context.Add(comp1);
      _context.SaveChanges();

      Competition competition = club.Seasons.SingleOrDefault(s => s.SeasonId == season.SeasonId).Competitions.First();
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

      if(_context.Competitors.SingleOrDefault(c => c.ClubId == club.ClubId && c.LastName == BARCLAY) != null)
        throw new Exception("AddCompetitors 5");

      if (club.Competitors.Count() != 8)
        throw new Exception("AddCompetitors 10");

      if (club.Seasons.Count() != 3)
        throw new Exception("AddCompetitors 20");

      if (club.Fish.Count() != 4)
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
      _context.Add(competitor1);
      Competitor competitor2 = new Competitor("Eden", "", "Mallini", club, Competitor.COMPETITOR_TYPE.JUNIOR, Competitor.GENDER.FEMALE);
      _context.Add(competitor2);
      Competitor competitor3 = new Competitor("Andrew", "MadDog", BARCLAY, club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor3);
      Competitor competitor4 = new Competitor("John", "", "Deveson", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor4);
      Competitor competitor5 = new Competitor("Gordon", "Flash", "McDonald", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor5);
      Competitor competitor6 = new Competitor("Len", "", "Brown", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor6);
      Competitor competitor7 = new Competitor("Rod", "", "King", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor7);
      Competitor competitor8 = new Competitor("Jason", "", "King", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor8);
      Competitor competitor9 = new Competitor("C", "", "Scott", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor9);
      Competitor competitor10 = new Competitor("Anthony", "Mr Laursiton", "Francis", club, Competitor.COMPETITOR_TYPE.NON_MEMBER, Competitor.GENDER.MALE);
      _context.Add(competitor10);
      Competitor competitor11 = new Competitor("Stuart", "", "Taylor", club, Competitor.COMPETITOR_TYPE.SENIOR, Competitor.GENDER.MALE);
      _context.Add(competitor11);

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

      if (_context.Clubs.Single(c => c.ClubId == club.ClubId).Fish.Count() != 4)
        throw new Exception("AddFish 10");

      _context.Fish.RemoveRange(_context.Fish.Where(f => f.ClubId == club.ClubId));
      _context.SaveChanges();

      if (_context.Clubs.Single(c => c.ClubId == club.ClubId).Fish.Count() != 0)
        throw new Exception("AddFish 20");

      AddFishDirect(club);

      if (_context.Clubs.Single(c => c.ClubId == club.ClubId).Fish.Count() != 4)
        throw new Exception("AddFish 30");

    }


    private void AddFishDirect(Club club)
    {
      Fish fish1 = new Fish(club, "Brown trout", 85, 28, 1, ENVIRONMENT.FRESHWATER);
      Fish fish2 = new Fish(club, "Rainbow trout", 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      Fish fish3 = new Fish(club, "Murray cod", 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      Fish fish4 = new Fish(club, "Bream", 45, 28, 1, ENVIRONMENT.ALL);

      _context.Fish.Add(fish1);
      _context.Fish.Add(fish2);
      _context.Fish.Add(fish3);
      _context.Fish.Add(fish4);

      _context.SaveChanges();
    }


    private void AddSeasons(Club club)
    {
      AddSeasonsDirect(club);

      if (club.Seasons.Count() != 3)
        throw new Exception("AddSeasons 2");

      _context.Seasons.RemoveRange(_context.Seasons.Where(s => s.ClubId == club.ClubId));
      _context.SaveChanges();

      if(club.Seasons.Count() != 0)
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
      _context.Add(season1);

      Season season2 = new Season(club, DateTime.Parse("5 September 2016"), DateTime.Parse("5 September 2017"));
      _context.Add(season2);

      Season season3 = new Season(club, DateTime.Parse("5 September 2017"), DateTime.Parse("5 September 2018"));
      _context.Add(season3);

      _context.SaveChanges();
    }


    public void Construction()
    {
      Club club = AddClub();

      AddFish(club);
      int clubId = club.ClubId;

      AddSeasons(club);

      int season1Id = club.Seasons.First().SeasonId;
      int season2Id = club.Seasons.Skip(1).First().SeasonId;

      AddCompetitors(club);

      AddCompetition(club);

      AddCatches(club);

      IEnumerable<Competition> competitions = club.Competitions;
      IEnumerable<Catch> catches = club.Competitions.First().Catches;

      if (catches.Count() != 7)
        throw new Exception("Construction 5");

      if(catches.First().Competition == null)
        throw new Exception("Construction 7");

      club.Competitions.First().Catches.RemoveAll(c => true);
      _context.SaveChanges();

      club.Competitors.RemoveAll(c => true);
      _context.SaveChanges();

      club.Competitions.RemoveAll(c => true);
      _context.SaveChanges();

      club.Fish.RemoveAll(c => true);
      _context.SaveChanges();

      _context.Clubs.Remove(club);
      _context.SaveChanges();


      if (_context.Seasons.SingleOrDefault(s => s.SeasonId == season1Id) != null)
        throw new Exception("Construction 10");

      if (_context.Seasons.SingleOrDefault(s => s.SeasonId == season2Id) != null)
        throw new Exception("Construction 20");

      if (_context.Competitors.SingleOrDefault(c => c.ClubId == clubId) != null)
        throw new Exception("Construction 30");

      if (_context.Catches.SingleOrDefault(c => c.Competition.Season.ClubId == clubId) != null)
        throw new Exception("Construction 40");

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
