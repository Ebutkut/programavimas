using System;


namespace Uzduotis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Išveskite pasirinkto skaičiaus daugybos lentelę. 

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int j, i;
            Console.Write("Įveskite skaičių : ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Daugybos lentelė: ");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", i, j, i * j);
            }

            /*
             * Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme. 
             * Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.
             */
            Console.WriteLine();
            int x = 56;
            int skaicius2 = x % 10;
            int skaicius1 = (x - skaicius2) / 10;

            Console.WriteLine("Skaičiaus {0} skaitmenys yra {1} ir {2} o jų sandauga = {3}", x,skaicius1, skaicius2, skaicius2 * skaicius1);

        }

    }
}
