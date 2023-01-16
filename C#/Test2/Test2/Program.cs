using System;


namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b, c;

            Console.WriteLine("Введите число: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);


            Console.WriteLine("Введите второе число: ");
            str= Console.ReadLine();
            b = Convert.ToInt32(str);

            c = a + b;
            Console.WriteLine("Ответ:\n" + c);
        }
    }
}
