using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rehearsal
{
    [TestClass]
    public class RehearsalTest
    {
        [TestMethod]
        public void SecondRehearsal()
        {
            int number = CalculateRehearsal(2, 2);
            Assert.AreEqual(4, number);
        }

        [TestMethod]

        public void ThirdRehearsal()
        {
            int number = CalculateRehearsal(3, 3);
            Assert.AreEqual(9, number);
        }
        int CalculateRehearsal(int totalNumberOfRehearsales, int round)
        {
            return round * round;
        }
    }
}



