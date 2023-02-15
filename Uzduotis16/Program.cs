using System;


namespace Uzduotis16
{
    internal class Program
    {
        static void Main()
        {
            // Raskite visų skaičių nuo 1 iki 100 sumą.
           
            int suma = 0;

            for (int i = 1; i < 101; i++)
            {
                suma += i;
            }

            Console.WriteLine(suma);

            //Raskite visų lyginių skaičių nuo 20 iki 40 sumą.

            suma = 0;

            for (int i = 20; i < 41; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine(suma);

            // Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.

            suma = 0;

            for (int i = 30; i < 61; i++)
            {
                if (i% 2== 1)
                {
                    suma += i;
                }
            }

            Console.WriteLine(suma);

            /*
             * Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba 5, sumą.
             * Pavyzdys:
             * Visi skaičiai mažesni už 10 ir kurie dalinasi iš 3 arba 5 yra: 3, 5, 6, 9.
             * Šių skaičių suma yra 23.
             * Turite gauti 233168 atsakymą.
             */

            suma = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                   suma += i;
                }
            }

            Console.WriteLine(suma);

        }
    }
}
