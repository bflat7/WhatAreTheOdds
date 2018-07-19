using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhatAreTheOdds;

namespace WhatAreTheOddsTests
{
    [TestClass]
    public class OddsLibraryTests
    {
        private static OddsLibrary oddsLibrary;

        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            oddsLibrary = new OddsLibrary();
        }

        [TestMethod]
        public void MatchTest()
        {
            OddsResults expectedValue = OddsResults.Match;
            int userValue = 10;
            int oppValue = 10;
            int odds = 20;
            OddsResults actualvalue = oddsLibrary.calculateOdds(userValue, oppValue, odds);
            Assert.AreEqual(expectedValue, actualvalue);
        }


        [TestMethod]
        public void NonMatchTest()
        {
            OddsResults expectedValue = OddsResults.NonMatch;
            int userValue = 10;
            int oppValue = 11;
            int odds = 20;
            OddsResults actualvalue = oddsLibrary.calculateOdds(userValue, oppValue, odds);
            Assert.AreEqual(expectedValue, actualvalue);
        }

        [TestMethod]
        public void ReMatchTest()
        {
            OddsResults expectedValue = OddsResults.ReMatch;
            int userValue = 5;
            int oppValue = 15;
            int odds = 20;
            OddsResults actualvalue = oddsLibrary.calculateOdds(userValue, oppValue, odds);
            Assert.AreEqual(expectedValue, actualvalue);
        }

        [TestMethod]
        public void RoleReversalTest()
        {
            OddsResults expectedValue = OddsResults.RoleReverse;
            int userValue = 2;
            int oppValue = 1;
            int odds = 2;
            OddsResults actualvalue = oddsLibrary.calculateOdds(userValue, oppValue, odds);
            Assert.AreEqual(expectedValue, actualvalue);
        }

        [TestMethod]
        public void BothInputInvalidTest()
        {
            bool expectedValue = false;
            int userValue = 11;
            int oppValue = 12;
            int odds = 10;
            bool actualValue = oddsLibrary.ValidateInput(userValue, oppValue, odds);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void InvalidInputTest()
        {
            bool expectedValue = false;
            int userValue = 9;
            int oppValue = 12;
            int odds = 10;
            bool actualValue = oddsLibrary.ValidateInput(userValue, oppValue, odds);
            Assert.AreEqual(expectedValue, actualValue);

            userValue = 123;
            oppValue = 9;
            odds = 10;
            actualValue = oddsLibrary.ValidateInput(userValue, oppValue, odds);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ValidInputTest()
        {
            bool expectedValue = true;
            int userValue = 9;
            int oppValue = 8;
            int odds = 10;
            bool actualValue = oddsLibrary.ValidateInput(userValue, oppValue, odds);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void NegativeInputTest()
        {
            bool expectedValue = false;
            int userValue = -9;
            int oppValue = 8;
            int odds = 10;
            bool actualValue = oddsLibrary.ValidateInput(userValue, oppValue, odds);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
