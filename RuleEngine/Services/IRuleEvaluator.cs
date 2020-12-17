using RuleEngine.Entities;

namespace RuleEngine.Services
{
    public interface IRuleEvaluator
    {
        public void Evaluate(Payment payment);
    }
}
