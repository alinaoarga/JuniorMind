using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trains
{
    [TestClass]
    public class TrainsTest
    {
        [TestMethod]
        public void FirstBirdTest()
        {
            double distance = CalculateBirdDistance(70);
            Assert.AreEqual(17.5d, distance);
        }
        [TestMethod]
        public void SecondBirdTest()
        {
            double distance = CalculateBirdDistance(60);
            Assert.AreEqual(15, distance);
        }
        double CalculateBirdDistance(double initialTrainDistance)
        {
            return initialTrainDistance / 4;
        }
    }
}
