using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Uzduotis26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Sugeneruokite atsitiktinio dydžio sąrašą, 
             * kurį užpildykite atsitiktiniais  skaičiais nuo 1 iki 100. 
             * Raskite:
             * mažiausią skaičių;
             * didžiausią skaičių;
             * vidurkį;
             * kiek skaičių yra žemesni už vidurkį;
             * lyginių skaičių sumą;
             */

            Console.WriteLine("Atsitiktiniai skaičiai: ");

            Random rand = new Random();
            int[] random = new int[100];
            for (int i = 0; i < random.Length ; i++)
            {
                random[i] = rand.Next(1,100);
                Console.Write("{0,3}   ", random[i]);
            }

            Console.WriteLine();

            int min = random.Min();
            int max = random.Max();
            double average = random.Average();
            Console.WriteLine($"Mažiausias skaičius: '{min}'");
            Console.WriteLine($"Didžiausias skaičius: '{max}'");
            Console.WriteLine($"Vidurkis: '{average}'");
            
            int count = 0;
            foreach (int i in random)
            {
                if (i < average) 
                count++;
            }
            Console.WriteLine($"Žemesnių už vidurkį skaičius: '{count}'");

            int sum = 0;
            foreach (int i in random)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine($"Lyginių skaičių suma: '{sum}'");
            Console.WriteLine();

            /*
             * Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.  
             * Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę.
             * Raskite:
             * didžiausią pažymį;
             * mažiausią pažymį;
             * vidurkį;
             */

            Console.Write("Kiek pažymių norite įvesti? ");
            int nr = Convert.ToInt32(Console.ReadLine());

            int[] pazymiai = new int[nr];

            for (int i = 0; i < pazymiai.Length; i++)
            {
                Console.Write("Įveskite pažymį: ");
                pazymiai[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"Didžiausias pažymys: {pazymiai.Max()}");
            Console.WriteLine($"Mažiausias pažymys: {pazymiai.Min()}");
            Console.WriteLine($"Pažymių vidurkis: {pazymiai.Average()}");
        }
    }
}
