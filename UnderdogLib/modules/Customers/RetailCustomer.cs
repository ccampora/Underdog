namespace Underdog.Customers
{
    public class RetailCustomer : ICustomer
    {
        public String customerName { get; set; }
        string ICustomer.address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICustomer.firstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICustomer.lastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RetailCustomer(String _customerName) {
            customerName = _customerName;
        }
        
    }
}