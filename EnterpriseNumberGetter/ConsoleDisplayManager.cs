using System;
using EnterpriseNumberGetter.Core;

namespace EnterpriseNumberGetter
{
    public class ConsoleDisplayManager : IDisplayManager
    {
        void IDisplayManager.PushOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}
