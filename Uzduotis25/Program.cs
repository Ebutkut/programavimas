using System;
using System.Linq;

namespace Uzduotis25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant tarpu.
             * Rasti  didžiausią pažymį.
             */

            Console.WriteLine("Įveskite 5 pažymius vienoje eilutėje atskiriant tarpu: ");
            
            string ivedimas = Console.ReadLine();
            string[] ivedimasIsskaidytas = ivedimas.Split(' ');
            int[] pazymiai = new int[5];
            for (int i = 0; i < pazymiai.Length; i++)
            {
                pazymiai[i] = Convert.ToInt32(ivedimasIsskaidytas[i]);

            }
            
            Console.WriteLine($"Didžiausias pažymys: {pazymiai.Max()}");
            Console.WriteLine();
;
            /*
             * Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant kableliu.
             * Rasti  mažiausią pažymį.
             */

            Console.WriteLine("Įveskite 5 pažymius vienoje eilutėje atskiriant kableliu: ");

            string ivedimas2 = Console.ReadLine();
            string[] ivedimasIsskaidytas2 = ivedimas2.Split(',');
            int[] pazymiai2 = new int[5];
            for (int i = 0; i < pazymiai2.Length; i++)
            {
                pazymiai2[i] = Convert.ToInt32(ivedimasIsskaidytas2[i]);

            }

            Console.WriteLine($"Mažiausias pažymys: {pazymiai2.Min()}");
        }
    }
}
