using DapperToDB.Models;
namespace DapperToDB.Data;


public interface IFilmData
{
    List<FilmTitleAndDescription> GetFilmsByDuration(int duration);
    List<string> GetFilmsByRatingG();
    List<FilmTitleAndReleaseYear> GetFilms();
}
