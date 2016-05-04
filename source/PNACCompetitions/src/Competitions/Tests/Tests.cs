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


    private void AddCatch(Club club)
    {
      DateTime dt = DateTime.Parse("24 March 2016 7:00pm");
      Competition competition = Manager.Get(_context, club, dt);

      AddCatchDirectSaturday(club, competition);

      _context.Catches.Remove(_context.Catches.SingleOrDefault(c => c.CompetitionId == competition.Id && c.Competitor.LastName == "Deveson"));
      _context.SaveChanges();

      if (_context.Catches.Where(c => c.CompetitionId == competition.Id).Count() != 6)
        throw new Exception("AddCatch 10");

      Season season = Manager.GetSeason(_context, club, dt);

      if (club.Seasons.SingleOrDefault(s => s.Id == season.Id).Competitions.SingleOrDefault(c => c.Venue == LAKE_FYANS) == null)
        throw new Exception("AddCatch 20");

      _context.Catches.RemoveRange(_context.Catches.Where(c => c.CompetitionId == competition.Id));
      _context.SaveChanges();

      AddCatchDirectSaturday(club, competition);
    }


    private void AddCatchDirectSaturday(Club club, Competition competition)
    {
      Season season = Manager.Get(_context, club, DateTime.Parse(START_FYANS), DateTime.Parse(END_FYANS));

      int no = club.Competitors.Where(c => c.LastName == BARCLAY).Count();

      _context.Add(new Catch(club.Competitors.Single(c => c.LastName == "Deveson"), competition, _context.Fish.Single(f => f.ClubId == club.Id && f.Name == BROWN_TROUT), 44));
      _context.Add(new Catch(club.Competitors.Single(c => c.FirstName == "Rod" && c.LastName == "King"), competition, _context.Fish.Single(f => f.ClubId == club.Id && f.Name == BROWN_TROUT), 56));
      _context.Add(new Catch(club.Competitors.Single(c => c.LastName == "Scott"), competition, _context.Fish.Single(f => f.ClubId == club.Id && f.Name == BROWN_TROUT), 42));
      _context.Add(new Catch(club.Competitors.Single(c => c.LastName == "Francis"), competition, _context.Fish.Single(f => f.ClubId == club.Id && f.Name == BROWN_TROUT), 41));

      _context.Add(new Catch(club.Competitors.Single(c => c.LastName == "Taylor"), competition, _context.Fish.Single(f => f.ClubId == club.Id && f.Name == RAINBOW_TROUT), 36));
      _context.Add(new Catch(club.Competitors.Single(c => c.LastName == "Brown"), competition, _context.Fish.Single(f => f.ClubId == club.Id && f.Name == RAINBOW_TROUT), 36));
      _context.Add(new Catch(club.Competitors.Single(c => c.FirstName == "Rod" && c.LastName == "King"), competition, _context.Fish.Single(f => f.ClubId == club.Id && f.Name == RAINBOW_TROUT), 33));

      _context.SaveChanges();

      Catch catch1 = _context.Competitions.SingleOrDefault(c => c.Id == competition.Id).Catches.Where(c => c.Competitor.LastName == "Deveson").First();

      if (!(catch1.Competitor.LastName == "Deveson" && catch1.Fish.Name == BROWN_TROUT && catch1.Length == 44))
        throw new Exception("AddCatchDirect 10");
    }



    private Club AddClub()
    {

      _context.Clubs.RemoveRange(_context.Clubs);
      _context.SaveChanges();

      Club prestonNorthcote = new Club("Northern Suburbs Fly Fishing Club");
      _context.Add(prestonNorthcote);

      _context.SaveChanges();
      int clubId = prestonNorthcote.Id;

      if (_context.Clubs.SingleOrDefault(s => s.Id == clubId) == null)
        throw new Exception("AddClub 10");

      return prestonNorthcote;
    }


    private void AddCompetition(Club club)
    {
      Season season = Manager.Get(_context, club, DateTime.Parse(START_FYANS), DateTime.Parse(END_FYANS));

      Competition comp1 = new Competition(LAKE_FYANS, "Anazac weekend", DateTime.Parse("23 March 2016"), DateTime.Parse("25 March 2016"), ENVIRONMENT.FRESHWATER, season);
      _context.Add(comp1);
      _context.SaveChanges();

      Competition competition = club.Seasons.SingleOrDefault(s => s.Id == season.Id).Competitions.First();
      if (competition.Venue != LAKE_FYANS)
        throw new Exception("AddCompetition 10");
    }


    private void AddCompetitors(Club club)
    {
      AddCompetitorsDirect(club);

      int no = _context.Competitors.Where(c => c.ClubId == club.Id && c.LastName == BARCLAY).Count();

      _context.Competitors.Remove(_context.Competitors.Where(c => c.ClubId == club.Id && c.LastName == "Patterson").First());
      _context.SaveChanges();
      _context.Competitors.Remove(_context.Competitors.Where(c => c.ClubId == club.Id && c.LastName == BARCLAY).First());
      _context.SaveChanges();
      _context.Competitors.Remove(_context.Competitors.Where(c => c.ClubId == club.Id && c.LastName == "Mallini").First());
      _context.SaveChanges();

      if(_context.Competitors.SingleOrDefault(c => c.ClubId == club.Id && c.LastName == BARCLAY) != null)
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

      int count = _context.Clubs.Single(c => c.Id == club.Id).Competitors.Count();

      //IEnumerable<Competitor> competitors = _context.Competitors;
      int no = _context.Clubs.Single(c => c.Id == club.Id).Competitors.Count();

      if (_context.Clubs.Single(c => c.Id == club.Id).Competitors.Count() != 11)
        throw new Exception("AddCompetitors 10");

      int competitor1Id = _context.Clubs.Single(c => c.Id == club.Id).Competitors.First().Id;
      int competitor2Id = _context.Clubs.Single(c => c.Id == club.Id).Competitors.Skip(1).First().Id;

      int no1 = _context.Competitors.Where(c => c.ClubId == club.Id).Count();

      if (no != 11)
        throw new Exception("AddCompetitors 20");

      if (_context.Competitors.SingleOrDefault(c => c.Id == competitor1Id) == null)
        throw new Exception("AddCompetitors 30");

      if (_context.Competitors.SingleOrDefault(c => c.Id == competitor2Id) == null)
        throw new Exception("AddCompetitors 40");
    }



    private void AddFish(Club club)
    {
      List<ENVIRONMENT> freshwater = new List<ENVIRONMENT>();
      freshwater.Add(ENVIRONMENT.FRESHWATER);

      List<ENVIRONMENT> all = new List<ENVIRONMENT>();
      freshwater.Add(ENVIRONMENT.FRESHWATER);
      freshwater.Add(ENVIRONMENT.SALTWATER);
      freshwater.Add(ENVIRONMENT.ESTUARY);

      Fish fish1 = new Fish(club, BROWN_TROUT, 85, 28, 1, ENVIRONMENT.FRESHWATER);
      Fish fish2 = new Fish(club, RAINBOW_TROUT, 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      Fish fish3 = new Fish(club, MURRAY_COD, 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      Fish fish4 = new Fish(club, BREAM, 45, 28, 1, ENVIRONMENT.ALL);

      _context.Fish.Add(fish1);
      _context.Fish.Add(fish2);
      _context.Fish.Add(fish3);
      _context.Fish.Add(fish4);

      _context.SaveChanges();

      if (_context.Clubs.Single(c => c.Id == club.Id).Fish.Count() != 4)
        throw new Exception("AddFish 10");

      _context.Fish.Remove(fish1);
      _context.Fish.Remove(fish2);
      _context.Fish.Remove(fish3);
      _context.Fish.Remove(fish4);
      _context.SaveChanges();

      if (_context.Clubs.Single(c => c.Id == club.Id).Fish.Count() != 0)
        throw new Exception("AddFish 20");

      fish1 = new Fish(club, "Brown trout", 85, 28, 1, ENVIRONMENT.FRESHWATER);
      fish2 = new Fish(club, "Rainbow trout", 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      fish3 = new Fish(club, "Murray cod", 85, 28, 1.2, ENVIRONMENT.FRESHWATER);
      fish4 = new Fish(club, "Bream", 45, 28, 1, ENVIRONMENT.ALL);

      _context.Fish.Add(fish1);
      _context.Fish.Add(fish2);
      _context.Fish.Add(fish3);
      _context.Fish.Add(fish4);

      _context.SaveChanges();

      if (_context.Clubs.Single(c => c.Id == club.Id).Fish.Count() != 4)
        throw new Exception("AddFish 30");

    }



    private void AddSeasons(Club club)
    {
      Season season1 = new Season(club, DateTime.Parse("5 September 2015"), DateTime.Parse("5 September 2016"));
      _context.Add(season1);

      Season season2 = new Season(club, DateTime.Parse("5 September 2016"), DateTime.Parse("5 September 2017"));
      _context.Add(season2);

      Season season3 = new Season(club, DateTime.Parse("5 September 2017"), DateTime.Parse("5 September 2018"));
      _context.Add(season3);

      _context.SaveChanges();

      IEnumerable<Season> seasons = _context.Seasons;
      int no = seasons.Count();

      if (_context.Clubs.Single(c => c.Id == club.Id).Seasons.Count() != 3)
        throw new Exception("AddSeasons 10");

      if (_context.Seasons.Where(s => s.ClubId == club.Id).Count() != 3)
        throw new Exception("AddSeasons 20");
    }


    public void Construction()
    {
      Club club = AddClub();

      AddFish(club);
      int clubId = club.Id;

      AddSeasons(club);

      int season1Id = club.Seasons.First().Id;
      int season2Id = club.Seasons.Skip(1).First().Id;

      AddCompetitors(club);

      AddCompetition(club);

      AddCatch(club);


      _context.Clubs.Remove(club);
      _context.SaveChanges();

      if (_context.Seasons.SingleOrDefault(s => s.Id == season1Id) != null)
        throw new Exception("Construction 10");

      if (_context.Seasons.SingleOrDefault(s => s.Id == season2Id) != null)
        throw new Exception("Construction 20");

      if (_context.Competitors.SingleOrDefault(c => c.ClubId == clubId) != null)
        throw new Exception("Construction 30");

      if (_context.Catches.SingleOrDefault(c => c.Competition.Season.ClubId == clubId) != null)
        throw new Exception("Construction 40");

    }


    #endregion



  }
}
