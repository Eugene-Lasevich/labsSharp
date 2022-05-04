using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3Task1;

namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Service.c)
        }
    }
}
