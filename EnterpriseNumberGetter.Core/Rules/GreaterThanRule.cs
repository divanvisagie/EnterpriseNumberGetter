namespace EnterpriseNumberGetter.Core.Rules
{
    public class GreaterThanRule : IRule<bool>
    {
        private int _counter; //The thing we are comparing against
        private int _measurement; //The thing we are comparing

        public GreaterThanRule(int measurement, int counter)
        {
            _counter = counter;
            _measurement = measurement;
        }

        bool IRule<bool>.Evaluate()
        {
            return _measurement > _counter;
        }
    }
}
