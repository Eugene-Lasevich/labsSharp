using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
   public class Room
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

    public class Client
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
            for (int i = 0; i < lstFreeRooms.Count; i++)
            {
                if (lstFreeRooms[i] == str)
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
                if (clients[i].getSurname() == str)
                {
                    tmp++;
                    Console.WriteLine(clients[i].getName() + '\t' + clients[i].getSurname() + '\t' + clients[i].room.getRoom() + '\t' + clients[i].room.getCost());
                }
            }

            if (tmp == 0)
            {
                Console.WriteLine("Client with given last name not found");
            }

        }


    }
}
