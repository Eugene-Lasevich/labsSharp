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
    public class ClientTests
    {
        [TestMethod()]
        public void getNameTest()
        {
            Client client = new Client();
            client.setName("Eugene");

            string str = "Eugene";

            Assert.AreEqual(str, client.getName());
        }


        [TestMethod()]
        public void getNameTest1()
        {
            Client client = new Client();
            client.setName("Kirill");

            string str = "Kirill";

            Assert.AreEqual(str, client.getName());
        }

        [TestMethod()]
        public void getSurnameTest()
        {
            Client client = new Client();
            client.setSurname("Lasevich");

            string str = "Lasevich";

            Assert.AreEqual(str, client.getSurname());
        }

        [TestMethod()]
        public void getSurnameTest1()
        {
            Client client = new Client();
            client.setSurname("Gapanovich");

            string str = "Gapanovich";

            Assert.AreEqual(str, client.getSurname());
        }
    }
}