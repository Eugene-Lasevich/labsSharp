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
    public class FootballTests
    {
        [TestMethod()]
        public void kindSportTest()
        {
            Football sport = new Football();
            string str = "Football";
            Assert.AreEqual(str, sport.kindSport());
        }
    }
}