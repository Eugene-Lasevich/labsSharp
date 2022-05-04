using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Service s = new Service();
            Console.WriteLine("Enter a number");
            double num;
            double.TryParse(Console.ReadLine(), out num);
            Console.WriteLine($"The result is {s.Calc(num)}");
            Console.ReadLine();
        }
    }
}
