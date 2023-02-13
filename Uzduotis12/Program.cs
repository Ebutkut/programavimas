using System;


namespace Uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Liepkite įvesti tris skirtingus skaičius. Suraskite, kuris iš šių skaičių yra didžiausias.

            //Console.WriteLine("Įveskite tris skirtingus skaičius: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //double number3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Iš šių skaičių didžiausias: " + Math.Max(number1, Math.Max(number2, number3)));

            /* 
             * Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
             * ar gautas rezultatas yra [8-10];
             * ar gautas rezultatas yra [5-8);
             * ar gautas rezultatas yra < 5.
             */

            Console.WriteLine("Įveskite egzamino rezultatą: ");
            int egzRez = Convert.ToInt32(Console.ReadLine());

            if (egzRez >= 8 && egzRez <= 10)
                Console.WriteLine("Rezultatas patenka į [8 - 10] intervalą ");
            if (egzRez >= 5 && egzRez < 8)
                Console.WriteLine("Rezultatas patenka į [5 - 8) intervalą ");
            if (egzRez > 0 && egzRez < 5)
                Console.WriteLine("Rezultatas mažiau už 5 ");
            Console.WriteLine("Pabaiga");
            Console.WriteLine();

            /*
             * Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
             * ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
             * ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
             * ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
             * ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.
             */

            Console.WriteLine("Įveskite du skaičius: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (number1 == 0 || number1 > number2) 
                Console.WriteLine("Pirmas skaičius didesnis už antrą arba lygus 0 ");
            if (number2 == 5 || number2 > number1)
                Console.WriteLine("Antras skaičius didesnis už pirmą arba lygus 5 ");
            if (number1 == 20 && number1 > number2)
                Console.WriteLine("Pirmas skaičius didesnis už antrą ir lygus 20 ");
            if (number2 > number1 && number2 < 100)
                Console.WriteLine("Antras skaičius didesnis už pirmą ir mažesnis už 100 ");


        }
    }
}
