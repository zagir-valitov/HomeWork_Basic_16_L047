using HomeWork_Basic_16_L047.Models;


namespace HomeWork_Basic_16_L047.Data
{
    public interface IFilmData
    {
        List<FilmModel> GetFilmsByDuration(int duration);
        List<string> GetFilmsByRating(string rating);
    }
}
