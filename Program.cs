using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstaraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrinterWindows epson = new Epson();
            PrinterWindows canon = new Canon();
            PrinterWindows laserjet = new LaserJet();

            epson.dimension = "10 * 11";
            canon.dimension = "9,5 * 12";
            laserjet.dimension = "12 * 12";

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. laserJet\n");

            Console.WriteLine("Nomor Printer [1...3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
            {
                epson.Show();
                epson.Print();
            }
            else if (nomorPrinter == 2)
            {
                canon.Show();
                canon.Print();
            }else if(nomorPrinter == 3) 
            {
                laserjet.Show();
                laserjet.Print();
            }
            else
            {
                Console.WriteLine("Terjadi kesalahan, silahkan coba lagi");
            }
            Console.ReadKey();
        }
    }
}
