using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2Task1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(Program.check_correct(12, 13, 14));
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(Program.check_correct(12, 12, 14));

        }
    }
}
