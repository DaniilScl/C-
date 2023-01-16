using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    internal class Program
    {
        static void Main(string[] args)

        {  

            Console.BackgroundColor= ConsoleColor.Green;    
            Console.ForegroundColor= ConsoleColor.Black;
            double Ar_a, Ar_b, Sum_A;

            Console.WriteLine("Arithmetic mean of 2 numbers\n");
            Console.WriteLine("Numder one: ");
            Ar_a = double.Parse(Console.ReadLine());

            Console.WriteLine("Number two: ");
            Ar_b = double.Parse(Console.ReadLine());

            Sum_A= (Ar_a + Ar_b) / 2;
            Console.WriteLine("Arithmetic mean of 2 numbers: " + Sum_A);
            Console.ReadLine();
        }
    }
}
