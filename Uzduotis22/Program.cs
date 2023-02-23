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
            
            int[] tempArray = new int[7] {5, 4, -1, 2, 3, 2, -1};
            

            foreach (int temp in tempArray)
            {
                Console.Write(tempArray + " ");
            }

            Console.WriteLine(); 
            
            int min = tempArray[0];

            foreach (int tempMin in tempArray)
            {
                if (tempMin < min)
                {
                    min = tempMin;
                }
            }

            Console.WriteLine($"Žemiausia temperatūra: '{min}'");

            int max = tempArray[0];

            foreach (int tempMax in tempArray)
            {
                if (tempMax > max)
                {
                    max = tempMax;
                }
            }

            Console.WriteLine($"Didžiausia temperatūra: '{max}'");

            double average = tempArray.Average();
            Console.WriteLine($"Vidurkis: '{tempArray.Average()}'");

            int count = 0;
            foreach (int tempZemiau in tempArray)
            {
                if (tempZemiau < average)
                    count++;
            }
            Console.WriteLine($"Temperatūrų, esančių žemiau už vidurkį, kiekis: '{count}'");

            count = 0;
            foreach (int tempAuksciau in tempArray)
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
            
            foreach (int pazymys in pazymiai)
            {
                Console.Write(pazymys + " ");
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
            foreach (int pazymys in pazymiai )
            {
                if (pazymys == 10)
                    count++;
            }
            Console.WriteLine($"Dešimtukus gavo '{count}' mokinys");

             count = 0;
            foreach (int pazymys in pazymiai)
            {
                if (pazymys < 4)
                    count++;
            }
            Console.WriteLine($"Neigiamą pažymį gavo '{count}' mokinių");

            average = pazymiai.Average();
            Console.WriteLine($"Pažymių vidurkis: '{pazymiai.Average()}'");
        }
    }
}
