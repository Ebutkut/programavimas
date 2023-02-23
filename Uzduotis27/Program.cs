using System;
using System.Collections.Generic;
using System.Linq;

namespace Uzduotis27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurti žodžių sąrašą.Rasti trumpiausią ir ilgiausią žodžius, 
             * juos išvesti į ekraną, prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.
             * Tip: string kintamasis iš tiesų yra char masyvas, todėl galite naudoti zodis.Length
             */

            List<string> words = new List<string> 
            { "šuo", "autobusas", "bepasikiskiakopusteliaudamas", "kompiuteris" };
           
            Console.WriteLine(string.Join (", ", words));
            Console.WriteLine();

            words = words.OrderByDescending(n => n.Length).ToList();
            string longest = words.First();
            string shortest = words.Last();

            Console.WriteLine($"Ilgiausias žodis:'{longest}' sudarytas iš {longest.Count()} raidžių");
            Console.WriteLine($"Trumpiausias žodis: '{shortest}' sudarytas iš {shortest.Count()} raidžių ");
        }
    }
}        

