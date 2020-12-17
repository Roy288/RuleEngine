using System;
using RuleEngine.Entities;
using RuleEngine.Entities.Rules;

namespace RuleEngine.Rules
{
    public class GenerateDuplicatePackingSlipRule : IRule
    {
        public void ApplyRule()
        {
            Console.WriteLine("Generated duplicate packing slip for royalty department.");
        }

        public bool CanApply(Product product)
        {
            return product.Category.Name == "Book";
        }
    }
}
