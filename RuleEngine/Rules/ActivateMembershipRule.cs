using RuleEngine.Entities;
using RuleEngine.Entities.Rules;
using System;

namespace RuleEngine.Rules
{
    public class ActivateMembershipRule : MembershipRule, IRule
    {
        public void ApplyRule()
        {
            Console.WriteLine("Membership activated");
            SendEmailToOwner(MembershipActionType.Activate);
        }

        public bool CanApply(Product product)
        {
            return product.Category.Name == "ActivateMembership";
        }
    }
}
