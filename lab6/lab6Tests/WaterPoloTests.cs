﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Tests
{
    [TestClass()]
    public class WaterPoloTests
    {
        [TestMethod()]
        public void kindSportTest()
        {
            WaterPolo sport = new WaterPolo();
            string str = "WaterPolo";
            Assert.AreEqual(str, sport.kindSport());
        }
    }
}