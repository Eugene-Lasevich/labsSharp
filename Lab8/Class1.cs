using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_
{
    public interface ITariff
    {
        public void ShowTariff();
        public double Price();
        public double Discount();
        public string Room();
    }
    public class Tariff : ITariff
    {
        private double discount;
        private double oldPrice;
        private double newPrice;
        private string room;

        public Tariff(string room, double price, double discount)
        {
            this.room = room;
            oldPrice = price;
            this.discount = discount;
            newPrice = oldPrice * (100 - this.discount) / 100;
        }

        public double Discount()
        {
            return discount;
        }

        public double Price()
        {
            return oldPrice;
        }

        public string Room()
        {
            return room;
        }        

        public void ShowTariff()
        {
            Console.WriteLine("Room: "+room + '\t' +"old price: "+ oldPrice + '\t' + "discount: " + discount + '\t'+ "new price: " + newPrice);
        }

    }
    public class Room
    {
        List<ITariff> Rooms = new List<ITariff>();

        private ITariff? tariff;

        public Room()
        {
            
        }

        public void Add(Tariff tariff)
        {
            Rooms.Add(tariff);
        }

        public void Show()
        {
            foreach (var cur in Rooms)
            {
                tariff = cur;
                tariff.ShowTariff();
                
            }
        }
        public double AveageCost()
        {
            double all_cost = 0;
            
            foreach (var current in Rooms)
            {
                double Cost = current.Price() * (100 - current.Discount()) / 100;
                all_cost += Cost;
            }
            //return $"Average cost - {all_cost / Rooms.Count}$";

            return all_cost / Rooms.Count;
        }


    }
}