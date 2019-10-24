namespace EnterpriseNumberGetter.Core.Rules
{
    public class LessThanRule : IRule<bool>
    {
        //TODO: Better document these comment and place this on constructors
        private int _counter; //The thing we are comparing it to
        private int _measurement; //The thing we are comparing

        public LessThanRule(int measurement ,int counter) 
        {
            _counter = counter;
            _measurement = measurement;
        }

        public bool Evaluate()
        {
            return _measurement < _counter;
        }
    }
}
