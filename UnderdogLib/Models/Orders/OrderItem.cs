namespace Underdog.Models.Orders;

public class OrderItem
{
    public string codeId { get; set; }
    public string productName { get; set; }
    public int quantity { get; set; }
    public float unitPrice { get; set; }
}
