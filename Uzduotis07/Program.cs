using System;


namespace Uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite vartotojui įvesti savo vardą ir amžių. 
             * Į ekraną išveskite: “Jūsų vardas {vardas}, o amžius {amžius}.”
             */

            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.Write("Įveskite savo amžių: ");
            string amzius = Console.ReadLine();
            Console.WriteLine($"Jūsų varas yra {vardas} , o amžius yra {amzius}");
            Console.WriteLine();

            /*
             * Liepkite vartotojui įvesti bet kokį simbolį. 
             * Atspausdinkite 3x3 kvadratą iš to simbolio.
             */

            char s;
            Console.Write("Įveskite, bet kokį simbolį: ");
            s = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("" + s + "  " + s + "  " + s + " ");
            Console.WriteLine("" + s + "  " + s + "  " + s + " ");
            Console.WriteLine("" + s + "  " + s + "  " + s + " ");
            Console.WriteLine();

            /*Liepkite vartotojui įvesti bet kokį skaičių. 
             * Išveskite į ekraną šio skaičiaus kvadratą.
             */

            double n;
            Console.Write("Įveskite bet kokį skaičių: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("" + n + "  " + n + "  " + n + " ");
            Console.WriteLine("" + n + "  " + n + "  " + n + " ");
            Console.WriteLine("" + n + "  " + n + "  " + n + " ");
            Console.WriteLine();

            /*Liepkite vartotojui įvesti tris skaičius. 
             * Išveskite visų šių skaičių sumą, nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. 
             * Pvz.:
             * 5 + 3 + 8 = 16
             */

            Console.WriteLine("Įveskite tris skaičius: ");
            double p1 = Convert.ToDouble(Console.ReadLine());
            double p2 = Convert.ToDouble(Console.ReadLine());
            double p3 = Convert.ToDouble(Console.ReadLine());
            double suma = p1 + p2 + p3;
            Console.WriteLine("{0} + {1} + {2} = {3} ", p1, p2, p3, suma);

        }
    }
}
