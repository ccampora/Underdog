namespace Underdog.Storage;

using Underdog.Orders;

public interface IStorage
{
    public void SaveOrder(IOrder order);
    public IOrder? GetOrder(System.Guid orderId);

    public List<IOrder> GetAllOrders();
}
