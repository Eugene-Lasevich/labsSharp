using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2Task1
{
    public class Program
    {
        public static bool check_correct(int side1, int side2, int side3)
        {
            if (side1 == side2 || side1 == side3 || side2 == side3) return true;
            else return false;

        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("App that checks if triangle is equicrual");
                Console.WriteLine("Chose option:");
                Console.WriteLine("1.Continue");
                Console.WriteLine("2.Exit");
                int option;
                int.TryParse(Console.ReadLine(), out option);
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter length of sides");
                        int side1, side2, side3;
                        int.TryParse(Console.ReadLine(), out side1);
                        int.TryParse(Console.ReadLine(), out side2);
                        int.TryParse(Console.ReadLine(), out side3);
                        if (check_correct(side1,side2, side3))
                            Console.WriteLine("Triangle is equicrual");
                        else
                            Console.WriteLine("Triangle isn't equicrual");
                        break;
                    case 2:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
