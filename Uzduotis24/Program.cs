using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Paklausti vartotojo, kiek duomenų nori įvesti į masyvą.
             * Pagal tai sukursime tokio dydžio masyvą.
             * Iš konsolės įvesti duomenis į masyvą.
             * Surasti 2 sumas:
             * Suma1 – kai masyvo elementas yra lyginis skaičius;
             * Suma2 – kai masyvo indeksas nėra lyginis skaičius;
             */

            Console.Write("Kiek duomenų norite įvesti? ");
            int kiek = Convert.ToInt32(Console.ReadLine());

            string[] duomenys = new string[kiek];

            for (int i = 0; i < duomenys.Length; i++)
            {
                Console.Write("Įveskite duomenis: ");
                duomenys[i] = Console.ReadLine();
            }
            Console.WriteLine();

            int suma1 = 0;

            for (int i = 0; i < duomenys.Length; i++)
            {
                if (i % 2 == 0)
                {
                    suma1 += i;
                }
            }

            Console.WriteLine($"Suma1 - kai masyvo elementas yra lyginis skaičius: '{suma1}'");
            Console.WriteLine();

            int suma2 = 0;

            for (int i = 0; i < duomenys.Length; i++)
            {
                if (i % 2 != 0)
                {
                    suma2 += i;
                }
            }

            Console.WriteLine($"Suma2 - kai masyvo indeksas nėra lyginis skaičius: '{suma2}'");
        }
    }
}
