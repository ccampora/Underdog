namespace Underdog.Customers
{
    public interface ICustomer
    {
        String customerName { get; set; }
        String address { get; set; }
        String firstName { get; set; }
        String lastName { get; set; }
    }
}