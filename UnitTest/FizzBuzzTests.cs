using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            [Test]
            public void FizzBuzz_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
            {
                Assert.That(Fizz.GetOutput(3), Is.StringMatching("Fizz"));
                Assert.That(Fizz.GetOutput(6), Is.StringMatching("Fizz"));
                Assert.That(Fizz.GetOutput(9), Is.StringMatching("Fizz"));
            }

        }
    }
}
