using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3Task2.Services;

namespace Lab3Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Services.Service service = new Services.Service();
            Console.WriteLine("Enter values a, b, and z:");
            double a, b, z, result;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out z);
            result = service.Calc(a, b, z);
            Console.WriteLine($"The result is {result}");
            Console.ReadLine();
        }
    }
}
