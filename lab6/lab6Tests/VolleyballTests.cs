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
    public class VolleyballTests
    {
        [TestMethod()]
        public void kindSportTest()
        {
            Volleyball sport = new Volleyball();
            string str = "Volleyball";
            Assert.AreEqual(str, sport.kindSport());
        }
    }
}