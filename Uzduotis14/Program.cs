using System;


namespace Uzduotis14
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Į ekraną išveskite kelis sunumeruotus pasirinkimus 
             * 1 - stacionarus kompiuteris
             * 2 - nešiojamas kompiuteris
             * 3 - planšetė.
             * Liepkite vartotojui įvesti pasirinkimo numerį. 
             * Pagal įvestą numerį išveskite atitinkamą tekstą.
             * Pvz:
             * a. nešiojamuoju kompiuteriu galite naudotis visur;
             * b. stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje;
             * c. planšete galite naudotis visur;
             * Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.
             */

            Console.WriteLine("Pasirinkimai: ");
            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nešiojamas kompiuteris");
            Console.WriteLine("3 - planšetė");
            Console.WriteLine();
            Console.Write("Įveskite pasirinkimo numerį: ");
            int numeris = Convert.ToInt32(Console.ReadLine());

            switch(numeris) 
            {
                case 1:
                    Console.WriteLine("Pasirinkote stacionarų kompiuterį");
                    break;
                case 2:
                    Console.WriteLine("Pasirinkote nešiojamą kompiuterį");
                    break;
                case 3:
                    Console.WriteLine("Pasirinkote planšetę");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra");
                    break;
            }
        }
    }
}
