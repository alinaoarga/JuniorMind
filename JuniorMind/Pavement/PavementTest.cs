using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pavement
{
    [TestClass]
    public class PavementTest
    {
        [TestMethod]
        public void FirstCobblestoneTest()
        {
           decimal number = CalculateCobblestoneNumber(6, 6, 4);
            Assert.AreEqual(4, number);
        }
       decimal CalculateCobblestoneNumber(decimal squareWidth, decimal squareLenght, decimal cobblestoneSide)
        {
            decimal lenght = Math.Ceiling(squareLenght / cobblestoneSide);
            decimal width = Math.Ceiling(squareWidth / cobblestoneSide);
            return lenght * width;
        }
    }
}
