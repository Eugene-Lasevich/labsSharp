using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Tests
{
    [TestClass()]
    public class SwimingTests
    {
        [TestMethod()]
        public void kindSportTest()
        {
            Swiming sport = new Swiming();
            string str = "Swimming";
            Assert.AreEqual(str, sport.kindSport());
        }
    }
}