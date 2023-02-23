using System;

namespace Uzduotis31
{

    /*  
     *  Parašykite sumos funkciją su 3 parametrais, kuris gražina int tipo atsakymą.
     *  Parašykite dalmens funkciją su 2 parametrais, kuris gražina double tipo  atsakymą.
     *  Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int number1 = 10;
            int number2 = 15;
            int number3 = 20;

            Console.WriteLine(p.Sum(number1, number2,number3));
            Console.WriteLine(p.Division(number2, number3));
        }

        internal int Sum(int x, int y, int z)
        { 
          return x + y + z;
        }

        internal double Division(int x, int y)
        {
            return (double) x / y;
        }
    }

}
