using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rehearsal
{
    [TestClass]
    public class RehearsalTest
    {
        [TestMethod]
        public void secondRehearsal()
        {
            int number = CalculateRehearsal(2, 2);
            Assert.AreEqual(4, number);
        }
        int CalculateRehearsal(int totalNumberOfRehearsales, int round)
        {
            return round * round;
        }
    }
        }
       
    

