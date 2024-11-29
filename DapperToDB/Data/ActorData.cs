using Dapper;
using Npgsql;
using Microsoft.Data.SqlClient;
using DapperToDB.Models;
using System.Reflection.Metadata;

namespace DapperToDB.Data;

internal class ActorData : IActorData
{
    string? _connectionString = null;
    public ActorData(string connect)
    {
        _connectionString = connect;
    }
    public List<string> GetUniqueNames()
    {
        //using (IDbConnection db = new SqlConnection(_connectionString))
        using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
        {
            return db.Query<string>("SELECT DISTINCT first_name FROM actor").ToList();
        }
    }

    public ActorModel? GetActorByID(int id)
    {
        //using (IDbConnection db = new SqlConnection(_connectionString))
        using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
        {
            var parameter = new { Actor_ID  = id };
            var sqlQuery = "SELECT * FROM actor WHERE actor_id = @Actor_ID";
            return db.Query<ActorModel>(sqlQuery, parameter).FirstOrDefault();
        }
    }

    public List<ActorNameAndLastName?> GetActorByLessThanFilms(int count)
    {
        using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
        {
            var parameters = new { Count = count };
            var sqlQuery = "" +
                "SELECT a.first_name, a.last_name, COUNT(f.film_id) " +
                "FROM film f " +
                "JOIN film_actor fa ON fa.film_id = f.film_id " +
                "JOIN actor a ON a.actor_id = fa.actor_id " +
                "GROUP BY a.first_name, a.last_name " +
                "HAVING COUNT(f.film_id) < @Count " +
                "ORDER BY a.first_name";
            return db.Query<ActorNameAndLastName>(sqlQuery, parameters).ToList();
        }
    }
}
