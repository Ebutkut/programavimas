using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis29
{
    internal class Greetings
    {
        
        internal static void GreetUserByNameAndAge(string name, string age)
        {
            Console.WriteLine($"Labas, {name} ({age} m.).");
            
        }

        internal static void GreetByHobby(string hobby)
        {
            Console.WriteLine($"Jūsų įrašytas hobis: {hobby}");
        }

    }
}
