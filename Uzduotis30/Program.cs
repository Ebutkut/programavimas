using System;


namespace Uzduotis30
{
    /* 
     * Leiskite vartotojui įvesti du sveikuosius skaičius į programą.  
     * Sukurkite ir panaudokite šiuos metodus:
     * Suma;
     * Skirtumas;
     * Sandauga;
     * Dalmuo;
     */

    internal class Program
    {

        public int sum(int number1, int number2)
        {
            
            return number1 + number2;
        }

        public int subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public int multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public int division(int number1, int number2)
        {
            return number1 / number2;

        }

            public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int number1, number2, sum, subtraction, multiplication, division;
            Program p1 = new Program();

            Console.WriteLine("Įvesti du skaičius: ");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            sum = p1.sum(number1, number2);
            subtraction = p1.subtraction(number1, number2);
            multiplication = p1.multiplication(number1, number2);
            division = p1.division(number1, number2);

            Console.WriteLine($"{number1} + {number2} = {sum}");
            Console.WriteLine($"{number1} - {number2} = {subtraction}");
            Console.WriteLine($"{number1} - {number2} = {multiplication}");
            Console.WriteLine($"{number1} / {number2} = {division}"); 
            Console.ReadLine();
        }
    }
}
