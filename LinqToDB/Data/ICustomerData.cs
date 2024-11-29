using LinqToDB.Models;

namespace LinqToDB.Data
{
    public interface ICustomerData
    {
        Task InsertCustomer(CustomerModel user);
        Task UpdateCustomer(CustomerModel user);
        Task DeleteCustomer(int id);
        Task <CustomerModel?> GetCustomerByID(int id);
        Task <List<CustomerModel>> GetCustomers();
        
    }
}