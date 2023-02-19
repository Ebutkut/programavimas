using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurkite kintamąjį, kuris pasakytų 
             * kiek automobilis vidutiniškai sunaudoja degalų 100 – ui km. 
             * Susikurkite masyvą, kuriame saugotumėte
             * skirtingose kelionėse nuvažiuotų kilometrų rodmenis. 
             * Raskite:
             * trumpiausią kelionę;
             * ilgiausią kelionę;
             * kiek kuro sąnaudų sunaudojo automobilis (skaičiavimui reikės rasti visus  nuvažiuotus km).
             */

            int kuroSanaudos = 7;

            int[] km = new int[5];
            km[0] = 50;
            km[1] = 100;
            km[2] = 35;
            km[3] = 150;
            km[4] = 60;

            int min = km[0];

            for(int i = 0; i < km.Length; i++)
            {
                if (km[i] < min)
                {
                    min = km[i];
                }
            }

            Console.WriteLine($"Trumpiausia kelionė: {min} km");

            int max = km[0];

            for (int i = 0; i < km.Length; i++)
            {
                if (km[i] > max)
                {
                    max = km[i];
                }
            }

            Console.WriteLine($"Ilgiausia kelionė: {max} km");

            int sumaKm = km.Sum();
            double sunaudotasKuras = (double)(sumaKm * kuroSanaudos)/100;

            Console.WriteLine($"Automobilis {sumaKm} km sunaudojo {sunaudotasKuras} litrų kuro.");
        }
    }
}
