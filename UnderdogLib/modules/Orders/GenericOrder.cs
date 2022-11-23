namespace Underdog.Orders;

public class GenericOrder : IOrder
{

    private readonly List<BasicProductOrder> listProducts; 
    public System.Guid orderId { get; }

    public GenericOrder()
    {
        listProducts = new List<BasicProductOrder>();
         orderId = Guid.NewGuid();
    }


    public void AddProductToOrder(BasicProductOrder p)
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

    public void ChangeQty(BasicProductOrder p, int qty)
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

    public List<BasicProductOrder> GetProductsFromOrder()
    {
        return listProducts;
    }

    public void RemoveProductFromOrder(BasicProductOrder p)
    {
        listProducts.Remove(p);
    }
}