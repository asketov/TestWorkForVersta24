using System.Collections.Generic;
using System.Threading.Tasks;
using Core;

namespace InterfacesDomain
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();
        Task PushOrderAsync(Order order);
        Task SaveAsync();
    }
}
