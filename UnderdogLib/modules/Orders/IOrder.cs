namespace Underdog.Orders;

public interface IOrder
{
    // contains a list of products
    void AddProductToOrder(GenericProductOrder p);
    void RemoveProductFromOrder(GenericProductOrder p);
    void ChangeQty(GenericProductOrder p, int qty); 
    List<GenericProductOrder> GetProductsFromOrder();
}

