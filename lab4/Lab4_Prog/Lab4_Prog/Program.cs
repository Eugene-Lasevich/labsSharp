using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Deposit deposit = Deposit.GetInstance();
            int option;

            Console.WriteLine("ABOBA");
            
            while (true)
            {

                Console.WriteLine("Chose option:\n");
                Console.WriteLine("1.Calculate revenue");
                Console.WriteLine("2.Change deposit ammount");
                Console.WriteLine("3.Change number of deposits");
                Console.WriteLine("4.Exit program");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter time period");
                        int period;
                        int.TryParse(Console.ReadLine(), out period);
                        Console.WriteLine($"General revenue for this period {bank.CalculateRevenue(period)}");
                        break;
                    case 2:
                        Console.WriteLine("Enter new deposit ammount");
                        int ammount;
                        int.TryParse(Console.ReadLine(), out ammount);
                        deposit.Ammount = ammount;
                        break;
                    case 3:
                        Console.WriteLine("Enter new number of deposits");
                        int numOfDeposits;
                        int.TryParse(Console.ReadLine(), out numOfDeposits);
                        bank.NumOfDeposits = numOfDeposits;
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }
        }
    }
}
