using HomeWork_Basic_16_L047.Data;


Console.WriteLine(" --- Home Work 16 ---\n");

var connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=5891;";
//connectionString = "Server=(localdb)\\mssqllocaldb;Database=adonetdb;Trusted_Connection=True;";

//----------------------------------------------------------------------
var actorList = new ActorData(connectionString);
var actor = actorList.GetUniqueNames();
for (int i = 0; i < actor.Count; i++)
{
    Console.WriteLine($"{i + 1})\t{actor[i]}");
}
Console.ReadLine();

//----------------------------------------------------------------------
var filmsStore = new FilmData(connectionString);
var filmDuration = filmsStore.GetFilmsByDuration(100);
for (int i = 0; i < filmDuration.Count; i++)
{
    Console.WriteLine($"{i + 1})\t[{filmDuration[i].Title}]\n\t{filmDuration[i].Description}\n");    
}
Console.ReadLine();

//----------------------------------------------------------------------
var filmRating = filmsStore.GetFilmsByRating("G");
for (int i = 0; i < filmRating.Count; i++)
{
    Console.WriteLine($"{i + 1})\t{filmRating[i]}");
}
Console.ReadLine();