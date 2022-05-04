using System;

namespace _153501_Lasevich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа в каждой строке, чтобы узнать целую чвсть деления их:");
            long first, second;
            first =Convert.ToInt64 (Console.ReadLine());
            second = Convert.ToInt64(Console.ReadLine());
            long result = first / second;
            Console.WriteLine("Ответ " + result);
        }
    }
}
