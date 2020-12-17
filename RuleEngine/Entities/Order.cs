using System;

namespace RuleEngine.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid PaymentId { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
