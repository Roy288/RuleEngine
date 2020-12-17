using RuleEngine.Entities;
using RuleEngine.Entities.Rules;
using System;
using System.Collections.Generic;

namespace RuleEngine.Services
{
    public class RuleEvaluator : IRuleEvaluator
    {
        private readonly IEnumerable<IRule> _rules;

      
        public RuleEvaluator(IEnumerable<IRule> rules)
        {
             _rules = rules;           
        }

        public void Evaluate(Payment payment)
        {
            foreach (var product in payment.Products)
            {
                Console.WriteLine(product.Name);
                foreach (var rule in _rules)
                    if (rule.CanApply(product))
                        rule.ApplyRule();
            }
        }
    }
}
