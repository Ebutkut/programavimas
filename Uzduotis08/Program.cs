using System;


namespace Uzduotis08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. 
             * Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.
             * Pvz.:
             * 2 * 1 = 2
             * …
             * 2 * 5 = 10
             */

            int j, i;
            Console.Write("Įveskite skaičių : ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Daugybos lentelė: ");
            for (j = 1; j <= 5; j++)
            {
                Console.Write("{0} X {1} = {2} \n", i, j, i * j);
            }
            Console.WriteLine();

            /* Liepkite vartotojui įvesti tris skaičius.
             * Į ekraną išveskite šiuos skaičius ir jų vidurkį.
             * Pvz.:
             * Įvestų skaičių 4, 5, 8 vidurkis: 5,7.
             */

            Console.WriteLine("Įveskite tris skaičius: ");
            double p1 = Convert.ToDouble(Console.ReadLine());
            double p2 = Convert.ToDouble(Console.ReadLine());
            double p3 = Convert.ToDouble(Console.ReadLine());
            double vidurkis = (p1 + p2 + p3) / 3;
            Console.WriteLine("Įvestų skaičių {0}, {1}, {2} vidurkis: " + vidurkis, p1, p2, p3);
            Console.WriteLine();

            /* Liepkite įvesti tris skaičius. 
             * Išveskite įvestus skaičius, jų kvadratus, juos pakeltus trečiuoju laipsniu,
             * taip pat tuos skaičius, padalintus iš dviejų.
             */

            Console.WriteLine("Įveskite tris skaičius: ");
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double m3 = Convert.ToDouble(Console.ReadLine());
            int y1 = 2;
            double pow1 = Math.Pow(m1, y1);
            double pow2 = Math.Pow(m2, y1);
            double pow3 = Math.Pow(m3, y1);
            Console.WriteLine("Įvesti skaičiai {0}, {1}, {2} pakelti kvadratu: {3}, {4}, {5}  ", m1, m2, m3, pow1, pow2, pow3);
            int y2 = 3;
            double pow4 = Math.Pow(m1, y2);
            double pow5 = Math.Pow(m2, y2);
            double pow6 = Math.Pow(m3, y2);
            Console.WriteLine("Įvesti skaičiai {0}, {1}, {2} pakelti trečiuoju laipsniu: {3}, {4}, {5}  ", m1, m2, m3, pow4, pow5, pow6);
            double r1 = (double)m1 / 2;
            double r2 = (double)m2 / 2;
            double r3 = (double)m3 / 2;
            Console . WriteLine ("Įvesti skaičiai {0}, {1}, {2} padalinti iš dviejų: {3}, {4}, {5}  ", m1, m2, m3, r1, r2, r3);






        }
    }
}
