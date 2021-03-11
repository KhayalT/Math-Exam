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


            Assert.AreEqual("Fizz",fizz.Test(3));
            Assert.AreEqual("Fizz",fizz.Test(6));
            Assert.AreEqual("Fizz",fizz.Test(9));

            Assert.AreEqual("Buzz", fizz.Test(5));
            Assert.AreEqual("Buzz", fizz.Test(10));
            Assert.AreEqual("Buzz", fizz.Test(20));

        }
    }
}
