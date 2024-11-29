using LinqToDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDB.Data
{
    public interface IOrderData
    {
        Task InsertOrder(OrderModel order);
        Task UpdateOrder(OrderModel order);
        Task DeleteOrder(int id);
        Task<OrderModel?> GetOrderByID(int id);
        Task<List<OrderModel>> GetOrders();
    }
}
