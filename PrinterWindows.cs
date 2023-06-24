using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstaraction
{
    public abstract class PrinterWindows
    {
        public string dimension { get; set; }
        public abstract void Print();
        public abstract void Show();
    }
}
