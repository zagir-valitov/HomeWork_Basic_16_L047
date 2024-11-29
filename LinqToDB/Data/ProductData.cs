using LinqToDB.DataAccess;
using LinqToDB.Models;


namespace LinqToDB.Data
{
    public class ProductData : IProductData
    {
        private readonly DbConnection _db;
        public ProductData(DbConnection db)
        {
            _db = db;
        }
        public Task DeleteProduct(int id)
        {
            return _db.Products.DeleteAsync(s => s.ProductID == id);
        }

        public Task<ProductModel?> GetProduct(int id)
        {
            return _db.Products.FirstOrDefaultAsync(s => s.ProductID == id);
        }

        public Task<List<ProductModel>> GetProducts()
        {
            return _db.Products.ToListAsync();
        }

        public Task<List<ProductModel>> GetProductsByFilter(string filter)
        {
            throw new NotImplementedException();
        }

        public Task InsertCustomer(ProductModel product)
        {
            return _db.InsertWithIdentityAsync(product);
        }

        public Task UpdateCustomer(ProductModel product)
        {
            return _db.UpdateAsync(product);
        }
    }
}
