using System;

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

            Console.WriteLine(ivedimas);
            
            //Console.WriteLine($"Didžiausias pažymys: {pazymiai.Max()}");



        }
    }
}
