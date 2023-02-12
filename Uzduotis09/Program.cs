using System;


namespace Uzduotis09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite vartotojui įvesti savo amžių. 
             * Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti”.
             */

            Console.WriteLine("Įveskite savo amžių: ");
            int ivestasAmzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (ivestasAmzius >= 18)
            {
                Console.WriteLine($"Jūs galite balsuoti");
            }
            Console.WriteLine();

            /*
             * Liepkite vartotojui įvesti bet kokį skaičių.
             * 1. Patikrinti, ar skaičius neigiamas, jei taip - aprėkti vartotoją;
             * 2. Patikrinti, ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
             * 3. Patikrinti, ar skaičius lyginis, jei taip - išvesti “taip, skaičius yra lyginis”;
             * 4. Patikrinti, ar skaičius dalinasi iš 4, jei taip - išvesti “taip, dalinasi iš 4”;
             * 5. Patikrinti, ar skaičius yra didesnis nei 10, jei taip - išvesti “taip, skaičius yra didesnis už 10”.
             */

            Console.WriteLine("Įveskite skaičių: ");
            double ivestasSkaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (ivestasSkaicius < 0)
                Console.WriteLine("Įvestas skaičius neigiamas ĄĄĄĄ!!!!!!!!!!");
            if (ivestasSkaicius >= 0)
                Console.WriteLine("Įvestas skaičius teigiamas, Sveikiname!");
            if (ivestasSkaicius % 2 == 0)
                Console.WriteLine("Taip, skaičius yra lyginis");
            if (ivestasSkaicius % 4 == 0)
                Console.WriteLine("Taip, skaičius dalinasi iš 4");
            if (ivestasSkaicius > 10)
                Console.WriteLine("Taip, skaičius yra didesnis už 10");
            Console.WriteLine();

            /*
             * Liepkite vartotojui įvesti du savo pažymius, 
             * raskite šių pažymių vidurkį, 
             * patikrinkite, ar vidurkis yra lygus arba didesnis už 5, 
             * jei taip, išveskite “Valio!!!”.
             */

            Console.WriteLine("Įveskite du savo pažymius: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double  number2 = Convert.ToDouble (Console.ReadLine());
            double vidurkis = (number1 + number2) / 2;
            Console.WriteLine("Pažymių vidurkis: " + vidurkis);
            if (vidurkis >= 5)
                Console.WriteLine("Valio!!!");


















        }
    }
}
