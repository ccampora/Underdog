namespace Underdog.Orders;

public interface IOrder
{
    public System.Guid orderId { get; }
    // contains a list of products
    void AddProductToOrder(BasicProductOrder p);
    void RemoveProductFromOrder(BasicProductOrder p);
    void ChangeQty(BasicProductOrder p, int qty); 
    List<BasicProductOrder> GetProductsFromOrder();
}

