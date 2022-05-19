using System;
using System.Collections.Generic;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Hostel Minsk = new Hostel();
            string tmp;

            do
            {
                Console.WriteLine("Enter free room number");
                Minsk.lstFreeRooms.Add(Console.ReadLine());
                Console.WriteLine("Enter cost free room");
                Minsk.lstCostRooms.Add(Console.ReadLine());

                Console.WriteLine("Do you want to complete the entery ?");
                Console.WriteLine("Types YES if you want to complete the input, otherwise any other character");

                tmp = Console.ReadLine();

            }
            while (tmp != "YES");



            string tmp_;
            do
            {
                Client client = new Client();

                Console.WriteLine("Enter name of client");
                client.setName(Console.ReadLine());

                Console.WriteLine("Entere surname of client");
                client.setSurname(Console.ReadLine());

                string tmp1;
                do
                {
                    Console.WriteLine("Enter the disired room");
                    tmp1 = Console.ReadLine();
                    if (Minsk.search_free_room(tmp1))
                    {
                        client.room.setRoom(tmp1);
                        client.room.setCost(Minsk.lstCostRooms[Minsk.find_free_room(tmp1)]);
                        Minsk.clients.Add(client);
                        string removeTmp;

                        removeTmp = Minsk.lstCostRooms[Minsk.find_free_room(tmp1)];
                        Minsk.lstCostRooms.Remove(removeTmp);
                        Minsk.lstFreeRooms.Remove(tmp1);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("This room is ocupied");
                        Console.WriteLine("Choose an avalible room from the  given list");
                        Minsk.print_free_rooms();
                    }
                } while (true);

                Console.WriteLine("Enter 1 for ending");
                tmp = Console.ReadLine();
            }
            while (tmp != "1");


            do
            {
                Console.WriteLine("Enter surname");
                Minsk.output_of_information(Console.ReadLine());
                Console.WriteLine("Enter 1 for end");
            }
            while (Console.ReadLine() != "1");


        }
    }
}
