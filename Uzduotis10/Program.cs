using System;

namespace Uzduotis10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* 
             * Liepkite įvesti skaičių.
             * Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.
             * Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių. 
             * Išveskite abiejų skaičių sumą ir sandaugą.
             */

            Console.WriteLine("Įveskite skaičių: ");
            int ivestasSkaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(ivestasSkaicius1 %2 == 0) 
            {
                Console.Write("Įvestas skaičius: " + ivestasSkaicius1);
                Console.WriteLine(" pakeltas penktuoju laipsniu: " + Math.Pow(ivestasSkaicius1, 5));
            }

            if (ivestasSkaicius1 % 4 == 0)
            {
                Console.WriteLine();   
            }
            
            else
            {
                Console.WriteLine("Įveskite dar vieną skaičių ");
                int ivestasSkaicius2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int suma = ivestasSkaicius1 + ivestasSkaicius2;
                int sandauga = ivestasSkaicius1 * ivestasSkaicius2;
                Console.WriteLine("Įvestų skaičių suma: " + suma);
                Console.WriteLine("Įvestų skaičių sandauga: " + sandauga);
            }
            
        }
    }
}
