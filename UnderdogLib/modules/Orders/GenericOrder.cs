namespace Underdog.Orders;

public class GenericOrder : IOrder
{

    private readonly List<GenericProductOrder> listProducts; 

    public GenericOrder()
    {
        listProducts = new List<GenericProductOrder>();
    }

    void IOrder.AddProductToOrder(GenericProductOrder p)
    {
        var product = listProducts.Find(product => product.codeId == p.codeId);
        if (product != null)
        {
            throw new Exception("The product can only be added once to the Order. To modify the quantity use the ChangeQty method");
        }

        else
        {
            listProducts.Add(p);
        }
    }

    void IOrder.ChangeQty(GenericProductOrder p, int qty)
    {
        var product = listProducts.Find(product => product.codeId == p.codeId);

        if (product == null)
        {
            throw new Exception("The Product is not in the order and its quantity cannot be changed");
        }

        else if(qty < 0)
            throw new Exception("New quantity cannot be negative");
        else if(qty == 0)
        {
            listProducts.Remove(product);
        }
        else
        {
            product.quantity = qty;
        }
    }

    List<GenericProductOrder> IOrder.GetProductsFromOrder()
    {
        return listProducts;
    }

    void IOrder.RemoveProductFromOrder(GenericProductOrder p)
    {
        listProducts.Remove(p);
    }
}