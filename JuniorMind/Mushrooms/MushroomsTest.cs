using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class MushroomsTest
    {
        [TestMethod]
        public void FirstMushroomsTest()
        {
            int number = CalculateNumberOfRedMushrooms(15, 4);
            Assert.AreEqual(12, number);
        }
        [TestMethod]
        public void SecondMushroomsTest()
        {
            int number = CalculateNumberOfRedMushrooms(12, 2);
            Assert.AreEqual(8, number);
        }
        [TestMethod]
        public void ThirdMushroomsTest()
        {
            int number = CalculateNumberOfRedMushrooms(18, 5);
            Assert.AreEqual(15, number);
        }
        int CalculateNumberOfRedMushrooms(int totalNumberOfMushrooms, int differenceBetweenRedAndWhiteMushrooms)
        {
            int firstPartOfFormula = totalNumberOfMushrooms * differenceBetweenRedAndWhiteMushrooms;
            int secondPartOfFarmula = differenceBetweenRedAndWhiteMushrooms + 1;
            return firstPartOfFormula / secondPartOfFarmula;
        }
    }
}
