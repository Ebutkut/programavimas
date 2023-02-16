using System;


namespace Uzduotis13
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite vartotojui įvesti tris skaičius. Su switch patikrinkite pirmąjį skaičių:
             * ar jis lygus 1: išveskite visų trijų skaičių sumą;
             * ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
             * ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
             */

            Console.WriteLine("Įveskite pirmą skaičių:");
            string ivedimas = Console.ReadLine();
            double skaicius1 = Convert.ToDouble(ivedimas);

            Console.WriteLine("Įveskite antrą skaičių:");
            ivedimas = Console.ReadLine();
            double skaicius2 = Convert.ToDouble(ivedimas);

            Console.WriteLine("Įveskite trečią skaičių:");
            ivedimas = Console.ReadLine();
            double skaicius3 = Convert.ToDouble(ivedimas);
            Console.WriteLine();

            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine("Įvestų skaičių suma: {0} ", skaicius1 + skaicius2 + skaicius3);
                    break;
                case 2:
                    Console.WriteLine("Pirmo ir trečio skaičių skirtumas: {0}", skaicius1 - skaicius3);
                    break;
                case 3:
                    Console.WriteLine("Antro ir tečio skaičių sandauga: {0} ", skaicius2 * skaicius3);
                    break;
            }
            Console.WriteLine();

            /*
             * Liepkite vartotojui įvesti gyvūno rūšį. Su switch patikrinkite:
             * ar įvestas gyvūnas yra šuo;
             * ar įvestas gyvūnas yra katė;
             * ar įvestas gyvūnas yra žiurkėnas.
             */

            Console.WriteLine("Įveskite gyvūno rūšį: ");
            string gyvunas = Console.ReadLine();
            

            switch (gyvunas)
            {
                case "suo":
                    Console.WriteLine("Teisingai, įvestas gyvūnas - šuo");
                    break;
                case "kate":
                    Console.WriteLine("Teisingai, įvestas gyvūnas - katė");
                    break;
                case "ziurkenas":
                    Console.WriteLine("Teisingai, įvestas gyvūnas - žiurkėnas");
                    break;
            }
        }
    }
}
