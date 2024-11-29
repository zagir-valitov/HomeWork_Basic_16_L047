using LinqToDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDB.Data
{
    public interface IProductData
    {
        Task InsertCustomer(ProductModel product);
        Task UpdateCustomer(ProductModel product);
        Task DeleteProduct(int id);
        Task<ProductModel?> GetProduct(int id);
        Task<List<ProductModel>> GetProducts();
        
    }
}
