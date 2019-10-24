using System;
using System.Linq;
using System.Collections;
using EnterpriseNumberGetter.Core.Rules;

namespace EnterpriseNumberGetter.Core
{

    public class NumberGetter
    {
        private IInputManager _inputManager;
        private IDisplayManager _displayManager;

        const int MIN = 1;
        const int MAX = 10;

        public NumberGetter(IInputManager inputManager, IDisplayManager displayManager)
        {
            _inputManager = inputManager;
            _displayManager = displayManager;
        }

        public int GetNumber()
        {
            _displayManager.PushOutput("Please enter a number between 1 and 10.");

            var input = _inputManager.GetInput();

            var parseSuccess = int.TryParse(input, out int number);

            if (!parseSuccess) 
            {
                throw new ArgumentException("The argument was of an invalid type.");
            } 
            
            var rangeCheck = new BooleanRuleChain();
            rangeCheck.Add(new GreaterThanRule(number, MAX));
            rangeCheck.Add(new LessThanRule(number, MIN));
            
            if (rangeCheck.EvaluateOr())
            {
                throw new ArgumentOutOfRangeException($"User input {input} was not within the required range.");
            }

            return number;
        }
    }
}
