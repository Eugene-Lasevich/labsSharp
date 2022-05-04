using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2Task2;
namespace Test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Program.check(0, -5));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, Program.check(0, 5));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(false, Program.check(10, 5));
        }
    }
}
