using Underdog.Orders;

namespace Underdog.Storage;

public class MemoryStorage : IStorage
{
    private readonly List<IOrder> orders;

    public MemoryStorage(List<IOrder> _orders)
    {
        orders = _orders;
    }
    public IOrder? GetOrder(Guid orderId)
    {
        if (orders == null)
        {
            return null;
        }
        else
        {
            return orders.Find(o => o.orderId == orderId);
        }

    }

    public void SaveOrder(IOrder order)
    {
        orders.Add(order);
    }

    public List<IOrder> GetAllOrders()
    {
        return orders;
    }
}