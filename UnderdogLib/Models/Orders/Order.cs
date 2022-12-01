using System;

namespace Underdog.Models.Orders
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset LastModifiedDate { get; set; }
        public Guid Owner { get; set; }
    }
}