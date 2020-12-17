namespace RuleEngine.Entities.Rules
{
    public interface IRule
    {
        public void ApplyRule();

        public bool CanApply(Product product);
    }
}
