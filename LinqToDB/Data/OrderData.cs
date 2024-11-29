using LinqToDB.DataAccess;
using LinqToDB.Models;

namespace LinqToDB.Data
{
    public class OrderData : IOrderData
    {
        private readonly DbConnection _db;
        public OrderData(DbConnection db)
        {
            _db = db;
        }


        public Task InsertOrder(OrderModel order)
        {
            return _db.InsertWithIdentityAsync(order);
        }

        public Task UpdateOrder(OrderModel order)
        {
            return _db.UpdateAsync(order);
        }

        public Task DeleteOrder(int id)
        {
            return _db.Orders.DeleteAsync(s => s.OrderID == id);
        }

        public Task<OrderModel?> GetOrderByID(int id)
        {
            return _db.Orders.LoadWith(q => q.Relations).FirstOrDefaultAsync(s => s.OrderID == id);
        }

        public Task<List<OrderModel>> GetOrders()
        {
            return _db.Orders.ToListAsync();
        }       
    }
}
