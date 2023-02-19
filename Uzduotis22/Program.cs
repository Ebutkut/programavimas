using System;
using System.Linq;


namespace Uzduotis22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurkite savaitės temperatūrų rodmenų masyvą. 
             * Raskite:
             * žemiausią temperatūrą;
             * didžiausią temperatūrą;
             * vidurkį;
             * Temperatūrų, esančių žemiau už vidurkį, kiekį;
             * Temperatūrų, esančių aukščiau už vidurkį, kiekį.
             */

            Console.WriteLine("Savaitės temperatūrų rodmenys: ");
            
            int[] temp = new int[7];
            temp[0] = 5;
            temp[1] = 4;
            temp[2] = -1;
            temp[3] = 2;
            temp[4] = 3;
            temp[5] = 2;
            temp[6] = -1;

            foreach (int tempS in temp)
            {
                Console.Write(tempS + " ");
            }

            Console.WriteLine(); 
            
            int min = temp[0];

            foreach (int tempMin in temp)
            {
                if (tempMin < min)
                {
                    min = tempMin;
                }
            }

            Console.WriteLine($"Žemiausia temperatūra: '{min}'");

            int max = temp[0];

            foreach (int tempMax in temp)
            {
                if (tempMax > max)
                {
                    max = tempMax;
                }
            }

            Console.WriteLine($"Didžiausia temperatūra: '{max}'");

            double average = temp.Average();
            Console.WriteLine($"Vidurkis: '{temp.Average()}'");

            int count = 0;
            foreach (int tempZemiau in temp)
            {
                if (tempZemiau < average)
                    count++;
            }
            Console.WriteLine($"Temperatūrų, esančių žemiau už vidurkį, kiekis: '{count}'");

            count = 0;
            foreach (int tempAuksciau in temp)
            {
                if (tempAuksciau > average)
                    count++;
            }
            Console.WriteLine($"Temperatūrų, esančių aukščiau už vidurkį, kiekis: '{count}'");
            Console.WriteLine();

            /*
             * Susikurkite studentų pažymių masyvą. Raskite:
             * geriausią pažymį; 
             * kiek mokinių yra gavę dešimtukus;
             * kiek mokinių yra gavę neigiamą pažymį (žemiau nei 4);
             * pažymių vidurkį.
             */

            Console.WriteLine("Studentų pažymiai: ");

            int[] pazymiai = new int[5];
            pazymiai[0] = 5;
            pazymiai[1] = 9;
            pazymiai[2] = 8;
            pazymiai[3] = 10;
            pazymiai[4] = 7;
            
            foreach (int pazymiaiS in pazymiai)
            {
                Console.Write(pazymiaiS + " ");
            }
            Console.WriteLine();
            
            max = pazymiai[0];

            foreach (int pazymys in pazymiai)
            {
                if (pazymys > max) 
                {
                    max = pazymys;
                }
            }

            Console.WriteLine($"Geriausias pažymys: '{max}'");

            count = 0;
            foreach (int gavoMax in pazymiai )
            {
                if (gavoMax == 10)
                    count++;
            }
            Console.WriteLine($"Dešimtukus gavo '{count}' mokinys");

             count = 0;
            foreach (int gavoNeig in pazymiai)
            {
                if (gavoNeig < 4)
                    count++;
            }
            Console.WriteLine($"Neigiamą pažymį gavo '{count}' mokinių");

            average = pazymiai.Average();
            Console.WriteLine($"Pažymių vidurkis: '{pazymiai.Average()}'");

        }
    }
}
