using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task2.Services
{
    public class Service
    {
        public double Calc(double a, double b, double z)
        {
            if (z < a * b)
            {
                Console.WriteLine("First branch");
                double x = Math.Sqrt(a * a + b * b * z);
                double y = (a * x + b * x * Math.Cos(Math.Sqrt(x))) / (x + a * b);
                // Console.WriteLine($"The result is {y}");\
                return y;
            }
            else
            {
                Console.WriteLine("Second branch");
                double x = Math.Sin(z) * Math.Sin(z) + Math.Abs(a * b * z);
                double y = (a * x + b * x * Math.Cos(Math.Sqrt(x))) / (x + a * b);
                //Console.WriteLine($"The result is {y}");
                return y;
            }
        }
    }
}
