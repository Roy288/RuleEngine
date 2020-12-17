using RuleEngine.Entities;
using System;

namespace RuleEngine.Rules
{
    public abstract class MembershipRule
    {
        public void SendEmailToOwner(MembershipActionType type)
        {
            Console.WriteLine($"Email sent for {type}");
        }
    }
}
