using RuleEngine.Entities;
using RuleEngine.Entities.Rules;
using System;
namespace RuleEngine.Rules
{
    public class GenerateCommisionPaymentRule : IRule
    {     

        public void ApplyRule()
        {
             Console.WriteLine("Generated commision payment.");
        }

        public bool CanApply(Product product)
        {
            return product.IsPhysicalProduct || product.Category.Name == "Book";
        }
    }
}
