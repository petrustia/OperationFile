using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperationFile;

namespace CheckOpFiles.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WeekDayOccReturns22()
        {
            FileOps mondayToFriday = new FileOps();

            int result = mondayToFriday.getWeekDayOccurences("3Mi");

            Assert.AreEqual(22, result);
        }

        [TestMethod]
        public void WeekEndOccReturns24()
        {
            FileOps saturdayAndSunday = new FileOps();

            int result = saturdayAndSunday.getWeekEndOccurences("7D");

            Assert.AreEqual(24, result);
        }
    }
}
