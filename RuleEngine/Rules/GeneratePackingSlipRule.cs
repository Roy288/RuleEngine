using System;
using RuleEngine.Entities;
using RuleEngine.Entities.Rules;
namespace RuleEngine.Rules
{
    public class GeneratePackingSlipRule : IRule
    {
        public void ApplyRule()
        {
           Console.WriteLine("Generated packing slip for shipping");
        }

        public bool CanApply(Product product)
        {
            return product.IsPhysicalProduct;
        }
    }
}
