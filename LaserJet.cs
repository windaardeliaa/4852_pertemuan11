using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstaraction
{
    public class LaserJet : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }

        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : {0}", dimension);
        }
    }
}
