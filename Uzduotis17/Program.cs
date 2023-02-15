using System;


namespace Uzduotis17
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite vartotojui įvesti teigiamą skaičių. 
             * Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0.
             * Pvz.: 
             * 5 4 3 2 1.
             * Kiekvieną kartą išvesti skirtingose eilutėse.
             */

            Console.Write("Įveskite teigiamą skaičių: ");
            double teigiamas = Convert.ToDouble(Console.ReadLine());

            while (teigiamas > 0)
            {
                Console.WriteLine(teigiamas);
                teigiamas--;
            }

            Console.WriteLine();

            /*
             * Liepkite vartotojui įvesti neigiamą skaičių. 
             * Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0. 
             * Pvz.:
             * -4 -3 -2 -1 0.
             * Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.
             */

            Console.Write("Įveskite neigiamą skaičių: ");
            double neigiamas = Convert.ToDouble(Console.ReadLine());

            while (neigiamas <= 0)
            {
                Console.Write("{0} ", neigiamas);
                neigiamas++;
            }

            Console.WriteLine();

            /*
             * Padarykite skaičiuotuvą. 
             * Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius. 
             * Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai,
             * išvedant kartu ir atliekamus veiksmus. 
             * Pvz.:
             * 5 + 4 = 9
             * 5 - 4 = 1
             * ...
             * Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
             */

            Console.WriteLine("Skaičiuotuvas");
            
            string atsTaip = "Taip";

            while(atsTaip == "Taip")
            {
                Console.WriteLine("Įveskite pirmą skaičių: ");
                string ivedimas = Console.ReadLine();
                double skaicius1 = Convert.ToDouble(ivedimas);
                Console.WriteLine("Įveskite antrą skaičių:");
                ivedimas = Console.ReadLine();
                double skaicius2 = Convert.ToDouble(ivedimas);

                Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, (skaicius1 + skaicius2));
                Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, (skaicius1 - skaicius2));
                Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, (skaicius1 * skaicius2));
                Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, (skaicius1 / skaicius2));
                Console.WriteLine();
                Console.WriteLine("Norite tęsti skaičiavimus (Taip/Ne): ");
                atsTaip = Console.ReadLine();

                switch(atsTaip)
                {
                    case "Taip":
                        break;
                    default:
                        Console.WriteLine("Pabaiga");
                        break;
                }
            }
        }
    }
}
