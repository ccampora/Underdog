using System;
using System.Linq;
using System.Threading.Tasks;
using Underdog.Models.Orders;

namespace Underdog.Brokers.Storages;
public partial interface IStorageBroker
{
    ValueTask<Order> InsertOrderAsync(Order order);
    IQueryable<Order> SelectAllOrders();
    ValueTask<Order> SelectOrderByIdAsync(Guid OrderId);
    ValueTask<Order> UpdateOrderAsync(Order order);
    ValueTask<Order> DeleteOrderAsync(Order order);
}