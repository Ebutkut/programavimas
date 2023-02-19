using System;


namespace Uzduotis11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* 
             * Liepkite vartotojui įvesti tris skaičius, 
             * parašyti šią patikrinimo sąlygą, naudojant else if dalis:
             * ar pirmas skaičius didesnis už antrą;
             * ar antras skaičius didesnis už trečią; 
             * ar trečias skaičius didesnis už pirmą;
             * ar pirmi du skaičiai lygūs;
             */

            Console.WriteLine("Įveskite tris skaičius: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (number1 > number2)
                Console.WriteLine("{0} daugiau už {1} ", number1, number2);
            else if (number2 > number3)
                Console.WriteLine("{0} daugiau už {1} ", number2, number3);
            else if (number3 > number1)
                Console.WriteLine("{0} daugiau už {1} ", number3, number1);
            if (number1 == number2)
                Console.WriteLine("Pirmi du skaičiai lygūs ");
            Console.WriteLine("Pabaiga");

            /* 
             * Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
             * ar temperatūra < 0 - išvesti “žiauriai šalta”;
             * ar temperatūra < 10 - išvesti “labai šalta”;
             * ar temperatūra < 20 - išvesti “šalta”;
             * ar temperatūra < 30 - išvesti “normali temperatūra”;
             * ar temperatūra < 40 - išvesti “karšta”;
             * ar temperatūra >= 40 - išvesti “visiškai degina”;
             */

            Console.WriteLine("Įveskite šios dienos oro temperatūrą: ");
            int oroTemperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (oroTemperatura < 0)
                Console.WriteLine("Žiauriai šalta ");
            else if (oroTemperatura < 10)
                Console.WriteLine("Labai šalta ");
            else if (oroTemperatura < 20) 
                Console.WriteLine("Šalta ");
            else if (oroTemperatura < 30)
                Console.WriteLine("Normali temperatūra ");
            else if (oroTemperatura < 40)
                Console.WriteLine("Karšta ");
            else if (oroTemperatura >= 40)
                Console.WriteLine("Visiškai degina ");
            Console.WriteLine("Pabaiga");







        }
}
}
