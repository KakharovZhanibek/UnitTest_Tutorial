using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int x = 2;
            int y = 2;

            //act
            int z = x + y;

            //assert
            Assert.IsTrue(z==4);
            Assert.AreEqual(4, z);
            
        }
    }
}
