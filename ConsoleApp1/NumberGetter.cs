using System;

namespace EnterpriseNumberGetter
{
    public class NumberGetter
    {
        private IInputManager _inputManager;

        public NumberGetter(IInputManager inputManager)
        {
            _inputManager = inputManager;
        }

        public int GetNumber()
        {
            Console.WriteLine("Please enter a number between 1 and 10.");

            var input = _inputManager.GetInput();

            var parseSuccess = int.TryParse(input, out int number);

            if (!parseSuccess || number > 10 || number < 1)
            {
                throw new Exception($"User input {input} was not a valid number.");
            }

            return number;
        }
    }
}
