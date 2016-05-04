 cd c:\yart\clients and jobs\PNACCompetitions\source\PNACCompetitions\src\MVC
 dnvm list
 dnvm use 1.0.0-rc1-update2 -p
 dnx ef migrations add v1 -p Competitions
 dnx ef database update