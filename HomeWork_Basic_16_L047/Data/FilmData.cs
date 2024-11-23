using HomeWork_Basic_16_L047.Models;
using Dapper;
using Npgsql;
using Microsoft.Data.SqlClient;


namespace HomeWork_Basic_16_L047.Data
{
    public class FilmData : IFilmData
    {
        string? _connectionString = null;
        public FilmData(string connect)
        {
            _connectionString = connect;
        }
        public List<FilmModel> GetFilmsByDuration(int duration)
        {
            //using (IDbConnection db = new SqlConnection(_connectionString))
            using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
            {
                return db.Query<FilmModel>($"SELECT title, description FROM film WHERE length > {duration}").ToList();
            }            
        }

        public List<string> GetFilmsByRating(string rating)
        {
            //using (IDbConnection db = new SqlConnection(_connectionString))
            using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
            {
                return db.Query<string>($"SELECT title FROM film WHERE rating = '{rating}'").ToList();
            }
        }
    }
}
