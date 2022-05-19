using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Tests
{
    [TestClass()]
    public class RoomTests
    {
        [TestMethod()]
        public void getRoomTest()
        {
            Room room = new Room();
            room.setRoom("Room1");

            string str = "Room1";
            Assert.AreEqual(str, room.getRoom());
        }

        [TestMethod()]
        public void getRoomTest1()
        {
            Room room = new Room();
            room.setRoom("");

            string str = "";
            Assert.AreEqual(str, room.getRoom());
        }

        [TestMethod()]
        public void setCostTest()
        {
            Room room = new Room();
            room.setCost("");

            string str = "";
            Assert.AreEqual(str, room.getCost());
        }

        [TestMethod()]
        public void setCostTest1()
        {
            Room room = new Room();
            room.setCost("500");

            string str = "500";
            Assert.AreEqual(str, room.getCost());
        }
    }
}