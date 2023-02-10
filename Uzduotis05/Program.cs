using System;


namespace Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį,
             * kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes. 
             * Pvz.:
             * 4 + 5 = 9
             * 4 - 5 = -1
             * …
             */

            int skaicius1 = 4;
            int skaicius2 = 5;
            Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
            Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
            Console.WriteLine($"{skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");

            //Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.

            Console.WriteLine();
            int skaicius3 = 6;
            Console.WriteLine(skaicius3);
            Console.WriteLine(Math.Pow((skaicius3),2));
            Console.WriteLine(Math.Pow((skaicius3),3));

            //Išveskite į ekraną trijų skaičių sandaugą.
            Console.WriteLine($"{skaicius1} * {skaicius2} * {skaicius3} = {skaicius1 * skaicius2 * skaicius3}");






        }
    }
}
