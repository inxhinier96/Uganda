using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgandaliConsole
{
    class ConsoleResponder : UgandaliMain.IResponder
    {
        public void ChangeBackgroundColor()
        {
            Console.WriteLine("renk değişmek üzere");
        }
    }
}
