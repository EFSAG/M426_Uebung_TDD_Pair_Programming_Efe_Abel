using Microsoft.VisualStudio.TestTools.UnitTesting;
using M426_Uebung_TDD_Pair_Programming_Efe_Abel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M426_Uebung_TDD_Pair_Programming_Efe_Abel.Tests
{
    [TestClass()]
    public class StringCalculatorTests
    {
        [TestMethod()]
        public void AddTestOnePlusFour()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(5, stringCalculator.Add("1,4"));
        }
        [TestMethod()]
        public void AddTestZero()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(0, stringCalculator.Add(""));
        }
        [TestMethod()]
        public void AddTestseven()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(7, stringCalculator.Add("7"));
        }
        [TestMethod()]
        public void AddTestSevenPlusEightPlusThree()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(18, stringCalculator.Add("7,8,3"));
        }
        // Test ob es geklappt hat, wenn ich mehrere Zahlen habe
        [TestMethod()]
        public void AddTestmoreValues()
        {
            var stringCalculator = new StringCalculator();
            Assert.AreEqual(25, stringCalculator.Add("4,5,6,7,3"));
        }
        [TestMethod()]
        public void CalledCountTest()
        {
            var stringCalculator = new StringCalculator();
            stringCalculator.Add("1,2");
            stringCalculator.Add("3,4");
            Assert.AreEqual(2, stringCalculator.CalledCount);
        }

    }
}