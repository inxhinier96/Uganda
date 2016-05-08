using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgandaliConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consol oyunu başladı!");
            Console.ReadKey();

            UgandaliMain.UgandaliMain main = new UgandaliMain.UgandaliMain();
            ConsoleResponder responder = new ConsoleResponder();

            main.Run(responder);

            Console.WriteLine("Console Oyunu Bitti");
            Console.ReadLine();
        }
    }
}
