using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Room rooms = new Room();

            string tmp;
            do
            {
                int price;
                int discount;
                string room;
                
                Console.WriteLine("Enter room");
                room = Console.ReadLine();

                Console.WriteLine("Enter price");
                price = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter discount");
                discount = int.Parse(Console.ReadLine());

                Tariff tariff = new Tariff(room, price, discount);
                rooms.Add(tariff);

                Console.WriteLine("Enter 1 to finish");
                tmp = Console.ReadLine();
            }
            while (tmp != "1");


            rooms.Show();         
            Console.WriteLine("\n"+ "Average cost: " + rooms.AveageCost());
        }
    }
}