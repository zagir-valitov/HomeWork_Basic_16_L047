using DapperToDB.Models;
using Dapper;
using Npgsql;

namespace DapperToDB.Data;


public class FilmData : IFilmData
{
    string? _connectionString = null;
    public FilmData(string connect)
    {
        _connectionString = connect;
    }
    public List<FilmTitleAndDescription> GetFilmsByDuration(int duration)
    {
        //using (IDbConnection db = new SqlConnection(_connectionString))
        using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
        {
            var parameters = new { Duration = duration };
            var sqlQuery = "SELECT title, description FROM film WHERE length > @Duration";
            return db.Query<FilmTitleAndDescription>(sqlQuery, parameters).ToList();           
        }             
    }

    public List<string> GetFilmsByRatingG()
    {
        //using (IDbConnection db = new SqlConnection(_connectionString))
        using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
        {
            var sqlQuery = "SELECT title FROM film WHERE rating = 'G'";
            return db.Query<string>(sqlQuery).ToList();
        }
    }

    public List<FilmTitleAndReleaseYear> GetFilms()
    {
        //using (IDbConnection db = new SqlConnection(_connectionString))
        using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
        {
            var sqlQuery = "SELECT title, release_year FROM film";
            return db.Query<FilmTitleAndReleaseYear>(sqlQuery).ToList();
        }
    }
}
