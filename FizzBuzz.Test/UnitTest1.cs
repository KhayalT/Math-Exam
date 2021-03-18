using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzz.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FizzBaz.Fizz fizz = new FizzBaz.Fizz();

            Assert.AreEqual("Fizz",fizz.Test(13));
          

        }
    }
}
