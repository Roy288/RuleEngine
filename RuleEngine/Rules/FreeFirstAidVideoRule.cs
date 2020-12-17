using RuleEngine.Entities;
using RuleEngine.Entities.Rules;
using System;

namespace RuleEngine.Rules
{
    public class FreeFirstAidVideoRule : IRule
    {
        public void ApplyRule()
        {           
                Console.WriteLine("A Free first aid video is added");
        }

        public bool CanApply(Product product)
        {
            return product.Category.Name == "Video" && product.Name == "Learning to Ski";
        }
    }
}
