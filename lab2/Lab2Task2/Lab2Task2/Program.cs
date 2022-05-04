using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task2
{

   public class Program
    {
        public static bool check(int x, int y)
        {
            if (x * x + y * y < 100 && y < Math.Abs(x)) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of the point");
            int x, y;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            if (check(x, y))
                Console.WriteLine("Point is in the area");
            else
                Console.WriteLine("Point isn't in the area");
            Console.ReadLine();

        }
    }
}
