using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goat
{
    [TestClass]
    public class GoatTest
    {
        [TestMethod]
        public void FirstTest()
        {
            float number = CalculateDifferentAmountOfHay(5, 10, 50, 10, 20);
            Assert.AreEqual(50, number);
        }
        [TestMethod]
        public void SecondTest()
        {
            float number = CalculateDifferentAmountOfHay(10, 2, 5, 4, 5);
            Assert.AreEqual(31.25f, number);
        }
        float CalculateDifferentAmountOfHay(int numberOfDays, int numberOfGoats, float amountOfHay, int differentNumberOfDays, int differentNumberOfGoats)
        {
            float numerator = numberOfDays * differentNumberOfGoats * amountOfHay;
            float denominator = differentNumberOfDays * numberOfGoats;
            return numerator / denominator;
        }

    }
}
