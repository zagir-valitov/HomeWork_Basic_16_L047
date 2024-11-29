using LinqToDB.DataAccess;
using LinqToDB.Models;


namespace LinqToDB.Data
{
    public class CustomerData : ICustomerData
    {
        private readonly DbConnection _db;
        public CustomerData(DbConnection db)
        {
            _db = db;
        }


        public Task InsertCustomer(CustomerModel customer)
        {
            return _db.InsertWithIdentityAsync(customer);
        }

        public Task UpdateCustomer(CustomerModel customer)
        {
            return _db.UpdateAsync(customer);
        }

        public Task DeleteCustomer(int id)
        {
            return _db.Customers.DeleteAsync(s => s.CustomerID == id);
        }

        public Task<CustomerModel?> GetCustomerByID(int id)
        {
            return _db.Customers.LoadWith(q => q.Relations).FirstOrDefaultAsync(s => s.CustomerID == id);
        }

        public Task<List<CustomerModel>> GetCustomers()
        {
            return _db.Customers.ToListAsync();
        }
                
        
    }
}
