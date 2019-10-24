using System;
using EnterpriseNumberGetter.Core;

namespace EnterpriseNumberGetter
{
    public class ConsoleInputManager : IInputManager
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
