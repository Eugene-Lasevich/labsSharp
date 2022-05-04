using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task1
{
    public class Service
    {
        public double Calc(double num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
                return num / 2;
            }
            else
            {
                Console.WriteLine("Number is odd");
                return num + 3;
            }
        }
    }
}