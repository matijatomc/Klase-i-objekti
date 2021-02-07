using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaKlaseIObjekti2
{
    class GeometrijskiLik
    {
        public int BrojStranica;
        public double[] Stranice = new double[10];

        public void UcitajStranice()
        {
            for (int i = 0; i < BrojStranica; i++)
            {
                Stranice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double Opseg()
        {
            double o = 0;
            for (int i = 0; i < BrojStranica; i++)
            {
                o = o + Stranice[i];
            }
            return o;
        }
    }
}
