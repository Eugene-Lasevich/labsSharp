using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Lab3_Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date as string");
            var date = Console.ReadLine();

            var Date = new DateService();

            Date.day(date);
            Date.span(date);
            Console.ReadLine();
        }
    }
}
