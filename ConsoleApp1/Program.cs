using System;
using System.Globalization;

namespace EnterpriseNumberGetter
{
    public class Application
    {
        public IInputManager InputManager { get; internal set; }
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

    public class ApplicationBuilder
    {
        private Application _application = new Application();

        public ApplicationBuilder AddInputManager(IInputManager inputManager)
        {
            _application.InputManager = inputManager;
            return this;
        }

        public Application Build() 
        {
            _application.NumberGetter = new NumberGetter(_application.InputManager);
            return _application;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var app = new ApplicationBuilder()
                .AddInputManager(new InputManager())
                .Build();

            var number = app.GetUserNumber();

            Console.WriteLine("The user chose: {0}", number);
            Console.ReadLine();
        }
    }
}
