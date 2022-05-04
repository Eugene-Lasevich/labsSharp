using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3Task2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task2.Services.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void CalcTest()
        {
            Service tmp = new Service();
            //Assert.AreEqual(-0.19860546322645, tmp.Calc(4, 5, 6));
            Assert.AreEqual(-.0199, Math.Round(tmp.Calc(4, 5, 6)), 3);
        }

        [TestMethod()]
        public void CalcTest1()
        {
            Service tmp = new Service();
            Assert.AreEqual(2.298, Math.Round(tmp.Calc(0, 4, 5)), 3);
        }
    }
}