using System;
using System.Collections.Generic;

namespace lab5
{
    class Program
    {

    class Room
        {
            private string room;
            private string cost;

            public void setRoom(string str)
            {
                room = str;
            }

            public string getRoom()
            {
                return room;
            }

            public void setCost(string str)
            {
                cost = str;
            }

            public string getCost()
            {
                return cost;
            }
        }

        class Client
        {
            private string name;
            private string surname;
            public Room room = new Room();

            public void setName(string str)
            {
                name = str;
            }

            public string getName()
            {
                return name;
            }

            public void setSurname(string str)
            {
                surname = str;
            }

            public string getSurname()
            {
                return surname;
            }




        }

        class Hostel
        {
            public List<string> lstFreeRooms = new List<string>();
            public List<string> lstCostRooms = new List<string>();
            public List<Client> clients = new List<Client>();

            public bool search_free_room(string str)
            {
                for(int i = 0; i< lstFreeRooms.Count; i++)
                {
                    if(lstFreeRooms[i] == str)
                    {
                        return true;
                    }
                }
                return false;
            }

            public int find_free_room(string str)
            {
                for (int i = 0; i < lstFreeRooms.Count; i++)
                {
                    if (lstFreeRooms[i] == str)
                    {
                        return i;
                    }
                }
                return -1;
            }

            public void print_free_rooms()
            {
                for (int i = 0; i < lstCostRooms.Count; i++)
                {
                    Console.WriteLine("free room - " + lstFreeRooms[i] + '\t' + "the room price - " + lstCostRooms[i]);

                }
            }

            public void output_of_information(string str)
            {
                int tmp = 0;
                for (int i = 0; i < clients.Count; i++)
                {
                   if(clients[i].getSurname() == str)
                   {
                       tmp++;
                       Console.WriteLine(clients[i].getName() + '\t' + clients[i].getSurname() + '\t' + clients[i].room.getRoom() + '\t' + clients[i].room.getCost());
                   }
                }

                if(tmp == 0)
                {
                    Console.WriteLine("Client with given last name not found");
                }
                
            }


        }
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
