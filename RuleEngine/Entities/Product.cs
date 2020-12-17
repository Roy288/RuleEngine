using System;

namespace RuleEngine.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public ProductCategory Category { get; set; }

        public bool IsPhysicalProduct => Category.Type == ProductType.Physical;
    }
}
