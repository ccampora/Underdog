namespace UnderdogTests;

public class StorageTests
{
    [Fact]
    void CallSaveOrder_AndIsSavedCorrectly_InMemoryStorage()
    {
        var storage = new MemoryStorage(new List<IOrder>());

        var order = new GenericOrder();
        order.AddProductToOrder(new BasicProductOrder { codeId = "001", productName = "Product 1", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "002", productName = "Product 2", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "003", productName = "Product 3", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "004", productName = "Product 4", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "005", productName = "Product 5", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "006", productName = "Product 6", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "007", productName = "Product 7", quantity = 10, unitPrice = 1.99f });


        storage.SaveOrder(order);

        var savedOrder = storage.GetOrder(order.orderId);

        Assert.True(savedOrder != null && order.GetProductsFromOrder().Count == savedOrder.GetProductsFromOrder().Count);

    }

    [Fact]
    void SaveToOrders_AndTheyArePersistenseInMemoryStorage()
    {
        var storage = new MemoryStorage(new List<IOrder>());

        var order = new GenericOrder();
        order.AddProductToOrder(new BasicProductOrder { codeId = "001", productName = "Product 1", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "002", productName = "Product 2", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "003", productName = "Product 3", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "004", productName = "Product 4", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "005", productName = "Product 5", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "006", productName = "Product 6", quantity = 10, unitPrice = 1.99f });
        order.AddProductToOrder(new BasicProductOrder { codeId = "007", productName = "Product 7", quantity = 10, unitPrice = 1.99f });


        storage.SaveOrder(order);

        var order2 = new GenericOrder();
        order2.AddProductToOrder(new BasicProductOrder { codeId = "001", productName = "Product 1", quantity = 10, unitPrice = 1.99f });
        order2.AddProductToOrder(new BasicProductOrder { codeId = "002", productName = "Product 2", quantity = 10, unitPrice = 1.99f });
        order2.AddProductToOrder(new BasicProductOrder { codeId = "003", productName = "Product 3", quantity = 10, unitPrice = 1.99f });
        order2.AddProductToOrder(new BasicProductOrder { codeId = "004", productName = "Product 4", quantity = 10, unitPrice = 1.99f });
        order2.AddProductToOrder(new BasicProductOrder { codeId = "005", productName = "Product 5", quantity = 10, unitPrice = 1.99f });
        order2.AddProductToOrder(new BasicProductOrder { codeId = "006", productName = "Product 6", quantity = 10, unitPrice = 1.99f });
        order2.AddProductToOrder(new BasicProductOrder { codeId = "007", productName = "Product 7", quantity = 10, unitPrice = 1.99f });


        storage.SaveOrder(order2);

        Assert.True(storage.GetAllOrders().Count == 2);
    }
}