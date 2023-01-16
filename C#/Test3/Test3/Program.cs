using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            double c, a, b;

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
            };


            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
  

            Console.WriteLine("Numder one: ");
            str = Console.ReadLine();
            bool result = double.TryParse(str, out a);


            if (result)
            {
                a = double.Parse(str, numberFormatInfo);
            }

            else
            {
                Console.WriteLine("Error");
                return;
            }


            Console.WriteLine("Numder two: ");
            str = Console.ReadLine();
            bool result2 = double.TryParse(str, out b);

            if (result2)
            {
                b = double.Parse(str, numberFormatInfo);
            }
            else
            {
                Console.WriteLine("Error");
                return;
            }

            c = a + b;
            Console.WriteLine("Answer: " + c);
            Console.ReadLine();


            ///Console.WriteLine("Continue click 1 close 2");
            ///str = Console.ReadLine();
            ///int close_a = Convert.ToInt32(str);
            ///bool close_b = int.TryParse(str, out close_a);
            ///if (close_b)
            ///{
            ///    close_b = true;
            ///    return;
            ///}
            ///else
            ///{
            ///    close_b = false;
            ///    break;
            ///}
        }
    }
}

       