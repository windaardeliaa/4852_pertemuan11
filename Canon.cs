using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstaraction
{
    public class Canon : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }

        public override void Show()
        {
            Console.WriteLine("Canon display dimension : {0}", dimension);
        }
    }
}
