using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using InterfacesDomain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext _db;

        public OrderRepository(OrderContext db)
        {
            _db = db;
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _db.Orders.AsNoTracking();
        }
        public async Task PushOrderAsync(Order order)
        {
            await _db.Orders.AddAsync(order);
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
