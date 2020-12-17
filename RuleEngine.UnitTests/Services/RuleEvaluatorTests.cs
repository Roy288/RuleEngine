using NUnit.Framework;
using RuleEngine.Entities;
using RuleEngine.Entities.Rules;
using RuleEngine.Services;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace RuleEngine.UnitTests.Services
{
    public class RuleEvaluatorTests
    {
        public IRuleEvaluator _evaluator;
        public List<Mock<IRule>> _rules;

        [SetUp]
        public void SetUp()
        {
            _rules = Enumerable.Range(1, 10).Select(i => new Mock<IRule>()).ToList();

            _evaluator = new RuleEvaluator(_rules.Select(_ => _.Object).ToList());
        }

        [Test]
        public void RuleEvaluatorChecksForApplicableRulesForEachProduct()
        {

            var products =
                Enumerable.Range(0, 20).Select(i =>
                new Product()).ToList();


            _evaluator.Evaluate(new Payment
            {
                Products = products
            });

            _rules.ForEach(_ => _.Verify(m => m.CanApply(It.Is<Product>(p => products.Contains(p)))));
        }
    }
}
