using LinqToDB.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDB.DataAccess
{
    public class DbConnectionSettings : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders
            => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "PostgreSQL";
        public string DefaultDataProvider => "PostgreSQL";

        //public string DefaultConfiguration => "SqlServer";
        //public string DefaultDataProvider => "SqlServer";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                // note that you can return multiple ConnectionStringSettings instances here
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "Postgres_ShopDB",
                        ProviderName = ProviderName.PostgreSQL,
                        ConnectionString = "Host=localhost;Port=5432;Database=Shop;Username=postgres;Password=5891;"
                    };               

                    //new ConnectionStringSettings
                    //{
                    //    Name = "adonetdb",
                    //    ProviderName = ProviderName.SqlServer,
                    //    ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=adonetdb;Trusted_Connection=True;"
                    //};

            }
        }
    }
}
