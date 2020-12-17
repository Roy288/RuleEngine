using System.Collections.Generic;

namespace RuleEngine.Entities
{
    public class Payment
    {
        // public IEnumerable<Order> Orders { get; set; }
        // public Product Product { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
