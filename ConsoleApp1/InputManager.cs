using System;

namespace EnterpriseNumberGetter
{
    public class InputManager : IInputManager
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
