using System;

namespace RuleEngine.Entities
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ProductType Type { get; set; }
    }
}
