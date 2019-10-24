namespace EnterpriseNumberGetter.Core.Rules
{
    public interface IRule<T>
    {
        T Evaluate();
    }
}
