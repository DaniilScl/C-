using System;


namespace dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            string str;

            Console.WriteLine("Введите первое число: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Введите второе число: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            Console.WriteLine("Введмте третье число: ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            d = a + b + c;
            e = a * b * c;
            Console.WriteLine("Сумма: " + d);
            Console.WriteLine("Произведение: " + e);
            Console.ReadLine();
        }
    }
}
