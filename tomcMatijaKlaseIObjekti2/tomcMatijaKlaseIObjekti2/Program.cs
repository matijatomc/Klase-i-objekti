using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaKlaseIObjekti2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Cetverokut cetverokut = new Cetverokut();

            Console.WriteLine("Upišite veličinu stranice za trokut: ");
            trokut.UcitajStranice();

            Console.WriteLine("Upišite veličinu stranice za cetverokut: ");
            cetverokut.UcitajStranice();

            double oTrokut = trokut.Opseg();
            double oCetverokut = cetverokut.Opseg();

            Console.WriteLine("Opseg trokuta je: " + oTrokut);
            Console.WriteLine("Opseg cetverokuta je: " + oCetverokut);

            Console.ReadKey();
        }
    }
}
