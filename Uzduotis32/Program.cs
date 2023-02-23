using System;

namespace Uzduotis32
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Paprašyti įvesti vartotojo vardą.
             * Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“.
             * Išvesti šią frazę į konsolę.
             */

            Console.Write("Įveskite savo vardą: ");
            string ivedimas = Console.ReadLine();
            GreetByName(ivedimas);
        }

        internal static void GreetByName(string name)
        {
            Console.WriteLine($"Sveiki, {name}");
        }
    }
}
