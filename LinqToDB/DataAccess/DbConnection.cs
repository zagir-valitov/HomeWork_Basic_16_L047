using LinqToDB.Models;
using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDB.DataAccess
{
    public class DbConnection : DataConnection
    {
        public DbConnection() : base("Postgres_ShopDB") 
        {
            (this as IDataContext).CloseAfterUse = true;
        }

        public ITable<CustomerModel> Customers => this.GetTable<CustomerModel>();
        public ITable<ProductModel> Products => this.GetTable<ProductModel>();
        public ITable<OrderModel> Orders => this.GetTable<OrderModel>();
    }
}
