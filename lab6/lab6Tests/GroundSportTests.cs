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
    public class GroundSportTests
    {
        [TestMethod()]
        public void kindSportTest()
        {
            GroundSport sport= new GroundSport();
            string str = "GroundSport";
            Assert.AreEqual(str, sport.kindSport());

        }
    }
}