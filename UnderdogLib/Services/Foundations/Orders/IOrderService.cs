using System;
using System.Linq;
using System.Threading.Tasks;
using Underdog.Models.Orders;

namespace Underdog.Services.Foundations.Orders;

public interface IOrderService
{
    ValueTask<Order> RegisterOrderAsync(Order order);
    IQueryable<Order> RetrieveAllOrders();
    ValueTask<Order> RetrieveOrderByIdAsync(Guid orderId);
    ValueTask<Order> ModifyOrderAsync(Order order);
    ValueTask<Order> RemoveOrderByIdAsync(Guid orderId);
}