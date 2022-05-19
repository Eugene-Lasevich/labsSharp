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
    public class WaterSportTests
    {
        [TestMethod()]
        public void kindSportTest()
        {
            WaterSport sport = new WaterSport();

            string str = "WaterSport";

            Assert.AreEqual(str, sport.kindSport());

        }
    }
}