using System;


namespace Uzduotis29

    /*
     * Parašykite metodą, kuris pasisveikintų su vartotoju.
     * Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
     * Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išveda formatuotai
     */

{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
    
            Console.WriteLine("Jūsų vardas ");
            string name = Console.ReadLine();
           
            Console.WriteLine("Jūsų amžius ");
            string age = Console.ReadLine();

            Console.WriteLine("Hobio pavadinimas ");
            string hobby = Console.ReadLine();

            Greetings.GreetUserByNameAndAge(name, age);
            Greetings.GreetByHobby(hobby);
        }
    }
}
