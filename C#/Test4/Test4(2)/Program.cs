using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            double Ar_a = 68.60;
            double Ar_b = 128.55;
            double Ar_c = 0.92;
            double Fn;
            double USD;
            

            Console.WriteLine("0. ВЫХОД\n" +
                "1. Перевести в JPY\n" +
                "2. Перевести в RUB\n" +
                "3. Перевести в EUR\n");
            Fn = double.Parse(Console.ReadLine());

            while (true)
            {
                if (Fn == 1)
                {
                    Console.WriteLine("Введите сумму в USD: ");
                    USD = double.Parse(Console.ReadLine());
                    Console.WriteLine(USD + " USD В JPY = " + USD * Ar_b);
                    Console.ReadLine();
                    return;
                }
                else if (Fn == 2)

                {
                    Console.WriteLine("Введите сумму в USD");
                    USD = double.Parse(Console.ReadLine());
                    Console.WriteLine(USD + " USD В RUB = " + USD * Ar_a);
                    Console.ReadLine();
                    return;
                }
                else if (Fn == 3)
                {
                    Console.WriteLine("Введите сумму в USD");
                    USD = double.Parse(Console.ReadLine());
                    Console.WriteLine(USD + " USD В EUR = " + USD * Ar_c);
                    Console.ReadLine();
                    return;
                }
                else if (Fn == 0)
                {
                    Console.WriteLine("Досвидание!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Не верное значение!!");
                    return;
                }
            }
         

            

        }
    }
}
