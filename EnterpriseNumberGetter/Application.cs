using System;
using EnterpriseNumberGetter.Core;

namespace EnterpriseNumberGetter
{
    public class Application
    {
        public IInputManager InputManager { get; internal set; }
        public IDisplayManager DisplayManager { get; internal set; }
        public NumberGetter NumberGetter { get; internal set; }

        public int GetUserNumber()
        {
            try
            {
                return NumberGetter.GetNumber();
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to get number: {0}", e);
                return GetUserNumber();
            }
        }
    }
}
