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
        float CalculateDifferentAmountOfHay(int numberOfDays, int numberOfGoats, float amountOfHay, int differentNumberOfDays, int differentNumberOfGoats)
        {
            return (numberOfDays*differentNumberOfGoats*amountOfHay)/(differentNumberOfDays*numberOfGoats);
        }

    }
}
