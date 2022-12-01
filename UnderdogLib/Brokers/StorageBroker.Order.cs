using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Underdog.Models.Orders;

namespace Underdog.Brokers.Storages;

public partial class StorageBroker
{
    public DbSet<Order> Orders { get; set; } = null;

    public async ValueTask<Order> DeleteOrderAsync(Order order) => 
        await DeleteAsync(order);

    public async ValueTask<Order> InsertOrderAsync(Order order) =>
        await InsertAsync(order);
    public IQueryable<Order> SelectAllOrders() => SelectAll<Order>();
    public async ValueTask<Order> SelectOrderByIdAsync(Guid OrderId) =>
        await SelectAsync<Order>(OrderId);

    public async ValueTask<Order> UpdateOrderAsync(Order order) =>
        await UpdateAsync(order);
}