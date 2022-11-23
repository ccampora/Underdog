namespace UnderdogTests;

public class OrdersTests
{
    // 
    [Fact]
    public void NewRetailCustomer_Name_isSet()
    {
        var customer = new RetailCustomer("Carlos");
        Assert.True(customer.customerName == "Carlos");
    }

    [Fact]
    public void AddProductToOrder_AndIsUnique()
    {
        String _codeId = "0001";
        String _productName = "Product1";
        int _qty = 10;
        float _price = 1.99f;

        var listProducts = new List<BasicProductOrder>();
        IOrder? order = new GenericOrder();
        var product = new BasicProductOrder { codeId = _codeId, productName = _productName, quantity = _qty, unitPrice = _price };
        Assert.True(condition: product.codeId == _codeId);
        Assert.True(condition: product.productName == _productName);

        order.AddProductToOrder(product);

        Exception ex = Assert.Throws<Exception>(() => order.AddProductToOrder(product));
        Assert.Equal("The product can only be added once to the Order. To modify the quantity use the ChangeQty method", ex.Message);

    }
    [Fact]
    public void ProductAddedToOrder()
    {
        String _codeId = "0001";
        String _productName = "Product1";
        int _qty = 10;
        float _price = 1.99f;

        IOrder? order = new GenericOrder();
        var product = new BasicProductOrder { codeId = _codeId, productName = _productName, quantity = _qty, unitPrice = _price };

        order.AddProductToOrder(product);

        var products = order.GetProductsFromOrder();

        List<BasicProductOrder> products1 = products.FindAll(p => p.codeId == _codeId);
        Assert.True(products1.Count == 1);

        Assert.True(condition: product.codeId == _codeId);
        Assert.True(condition: product.productName == _productName);
        Assert.True(product.quantity == _qty);
        Assert.True(product.unitPrice == _price);
    }

    [Fact]
    public void ChangeProductOrderQty_andQtyIsChangedCorrectly()
    {
        String _codeId = "0001";
        String _productName = "Product1";
        int _qty = 10;
        float _price = 1.99f;

        IOrder? order = new GenericOrder();
        var product = new BasicProductOrder { codeId = _codeId, productName = _productName, quantity = _qty, unitPrice = _price };

        order.AddProductToOrder(product);

        var products = order.GetProductsFromOrder();

        var productOrder = products.Find(p => p.codeId == _codeId);

        Assert.True(product.quantity == _qty);

        order.ChangeQty(product, 20);

        productOrder = products.Find(p => p.codeId == _codeId);

        Assert.True(productOrder != null && productOrder.quantity == 20);

        if (productOrder != null)
        {

            Exception ex1 = Assert.Throws<Exception>(() => order.ChangeQty(productOrder, -10));
            Assert.Equal("New quantity cannot be negative", ex1.Message);

            order.RemoveProductFromOrder(productOrder);

            Exception ex2 = Assert.Throws<Exception>(() => order.ChangeQty(productOrder, 10));
            Assert.Equal("The Product is not in the order and its quantity cannot be changed", ex2.Message);
        }
    }

    [Fact]
    public void RemoveProductOrder_AndIsRemovedCorrectly()
    {
        String _codeId = "0001";
        String _productName = "Product1";
        int _qty = 10;
        float _price = 1.99f;

        IOrder? order = new GenericOrder();
        var product = new BasicProductOrder { codeId = _codeId, productName = _productName, quantity = _qty, unitPrice = _price };

        order.AddProductToOrder(product);

        var products = order.GetProductsFromOrder();

        var productOrder = products.Find(p => p.codeId == _codeId);

        Assert.True(productOrder != null);

        order.RemoveProductFromOrder(product);

        productOrder = products.Find(p => p.codeId == _codeId);

        Assert.True(productOrder == null);
    }
}