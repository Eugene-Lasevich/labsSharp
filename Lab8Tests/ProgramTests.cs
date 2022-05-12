using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            double expected = 250;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612", 500, 50);
            rooms.Add(tariff);

            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MainTest1()
        {
            double expected = 250;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612", 500, 50);
            Tariff tariff1 = new Tariff("612", 500, 50);
            rooms.Add(tariff);
            rooms.Add(tariff1);

            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MainTest2()
        {
            double expected = 375;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612", 500, 50);
            Tariff tariff1 = new Tariff("612", 500, 0);
            rooms.Add(tariff);
            rooms.Add(tariff1);

            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MainTest3()
        {
            double expected = 500;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612a", 500, 0);
            Tariff tariff1 = new Tariff("509", 500, 0);
            Tariff tariff2 = new Tariff("507", 500, 0);
            rooms.Add(tariff);
            rooms.Add(tariff1);
            rooms.Add(tariff2);

            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MainTest4()
        {
            double expected = 0;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612", 500, 100);
            rooms.Add(tariff);

            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MainTest5()
        {
            double expected = 170;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612", 500, 66);
            rooms.Add(tariff);

            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void MainTest6()
        {
            double expected = 115.5;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612", 350, 67);
            rooms.Add(tariff);

            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MainTest7()
        {
            double expected = 240.83333333333334;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612a", 350, 35);
            Tariff tariff1 = new Tariff("509", 450, 45);
            Tariff tariff2 = new Tariff("507", 550, 55);
            rooms.Add(tariff);
            rooms.Add(tariff1);
            rooms.Add(tariff2);

            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MainTest8()
        {
            double expected = 0.9333333333333335;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612a", 4, 70);
            Tariff tariff1 = new Tariff("509", 5, 80);
            Tariff tariff2 = new Tariff("507", 6, 90);
            rooms.Add(tariff);
            rooms.Add(tariff1);
            rooms.Add(tariff2);

            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MainTest9()
        {
            double expected = 1316.2333333333333;

            Room rooms = new Room();
            Tariff tariff = new Tariff("612a", 500, 0);
            Tariff tariff1 = new Tariff("509", 500, 0);
            Tariff tariff2 = new Tariff("614", 750, 75);
            Tariff tariff3 = new Tariff("507", 10000, 33);
            Tariff tariff4 = new Tariff("104", 78, 91);
            Tariff tariff5 = new Tariff("111", 3, 4);
            rooms.Add(tariff);
            rooms.Add(tariff1);
            rooms.Add(tariff2);
            rooms.Add(tariff3);
            rooms.Add(tariff4);
            rooms.Add(tariff5);
            double actual = rooms.AveageCost();

            Assert.AreEqual(expected, actual);
        }
    }
}