using NUnit.Framework;
using RuleEngine.Entities;
using RuleEngine.Entities.Rules;
using RuleEngine.Rules;
using System;

namespace RuleEngine.UnitTests.Rules
{
    public class ActivateMembershipRuleTests
    {
        public IRule _activateMemberShipRule;

        [SetUp]
        public void SetUp()
        {
            _activateMemberShipRule = new ActivateMembershipRule();
        }

        [Test]
        public void ActivateMembershipRuleIsApplicableForActivateMemberShipProduct()
        {
            var product = new Product
            {
                Category = new ProductCategory
                {
                    Name = "ActivateMembership"
                }
            };

          Assert.That(_activateMemberShipRule.CanApply(product),Is.True);
        }

        [Test]
        public void ActivateMembershipRuleIsNotApplicableForOtherProducts()
        {
            var product = new Product
            {
                Category = new ProductCategory
                {
                    Name = Guid.NewGuid().ToString()
                }
            };

            Assert.That(_activateMemberShipRule.CanApply(product), Is.False);
        }
    }
}
