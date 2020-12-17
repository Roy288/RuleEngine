using RuleEngine.Entities;
using RuleEngine.Entities.Rules;
using System;

namespace RuleEngine.Rules
{
    public class UpgradeMembershipRule : MembershipRule, IRule
    {
        public void ApplyRule()
        {
           
            Console.WriteLine("Membership Upgraded.");
            SendEmailToOwner(MembershipActionType.Upgrade);
        }

        public bool CanApply(Product product)
        {
            return product.Category.Name == "UpgradeMembership";
        }
    }
}
