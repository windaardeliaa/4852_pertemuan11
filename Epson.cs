using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstaraction
{
    public class Epson : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }

        public override void Show() 
        {
            Console.WriteLine("Epson display dimension : {0}", dimension);
        }
    }
}
