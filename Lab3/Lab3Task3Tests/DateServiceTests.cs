using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task3.Tests
{
    [TestClass()]
    public class DateServiceTests
    {
        [TestMethod()]
        public void spanTest()
        {
            DateService tmp = new DateService();
            Assert.AreEqual(6676, tmp.span("08.01.2004"));
        }
    }
}