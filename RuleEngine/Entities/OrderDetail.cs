using System;

namespace RuleEngine.Entities
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
