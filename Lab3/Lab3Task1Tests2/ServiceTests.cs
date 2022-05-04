using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task1.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void CalcTest()
        {
            Service tmp = new Service();
            Assert.AreEqual(8, tmp.Calc(5));
        }

        [TestMethod()]
        public void CalcTest1()
        {
            Service tmp = new Service();
            Assert.AreEqual(4,tmp.Calc(8));
        }
    }
}