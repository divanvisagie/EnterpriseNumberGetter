using System;
using System.Globalization;

namespace EnterpriseNumberGetter
{

    class Program
    {
        static void Main(string[] args)
        {
            var app = new ApplicationBuilder()
                .AddInputManager(new ConsoleInputManager())
                .AddDisplayManager(new ConsoleDisplayManager())
                .Build();

            var number = app.GetUserNumber();

            Console.WriteLine("The user chose: {0}", number);
            Console.ReadLine();
        }
    }
}
