using System;
using System.Linq;
using System.Threading.Tasks;
using Underdog.Models.Orders;

namespace Underdog.Services.Foundations.Orders;

public partial class OrderService : IOrderService
{
    public ValueTask<Order> ModifyOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Order> RegisterOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Order> RemoveOrderByIdAsync(Guid orderId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Order> RetrieveAllOrders()
    {
        throw new NotImplementedException();
    }

    public ValueTask<Order> RetrieveOrderByIdAsync(Guid orderId)
    {
        throw new NotImplementedException();
    }
}
