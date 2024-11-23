using Dapper;
using Npgsql;
using Microsoft.Data.SqlClient;


namespace HomeWork_Basic_16_L047.Data
{
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
    }
}
