﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4_Prog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Prog.Tests
{
    [TestClass()]
    public class BankTests
    {
        [TestMethod()]
        public void CalculateRevenueTest()
        {
            Bank tmp = new Bank();
            Assert.AreEqual(12.682, Math.Round(tmp.calculaterevenue(12), 3));
        }
    }
}