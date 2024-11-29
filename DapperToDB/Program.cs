using DapperToDB.Data;


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
var actorByID = actorList.GetActorByID(2);
Console.WriteLine($"Actor ID - { actorByID.Actor_ID } : { actorByID.First_Name } { actorByID.Last_Name }");
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
var filmRating = filmsStore.GetFilmsByRatingG();
for (int i = 0; i < filmRating.Count; i++)
{
    Console.WriteLine($"{i + 1})\t{filmRating[i]}");
}
Console.ReadLine();

//----------------------------------------------------------------------
var films = filmsStore.GetFilms();
for (int i = 0; i < films.Count; i++)
{
    Console.WriteLine(
        $"{i + 1})\t{films[i].Title}" +
        $"\n\t(Release Year: {films[i].Release_Year})\n");
}
Console.ReadLine();

//----------------------------------------------------------------------
var actorLess = actorList.GetActorByLessThanFilms(20);
for (int i = 0; i < actorLess.Count; i++)
{
    Console.WriteLine($"{i + 1})\t{actorLess[i].First_Name} {actorLess[i].Last_Name}");
}
Console.ReadLine();
