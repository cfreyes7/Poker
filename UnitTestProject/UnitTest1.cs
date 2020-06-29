using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> cards = new List<int>{ 2, 3 ,4 ,5 ,6 };
           
            var results = Poker.PokerStraigth.isStraight(cards);
            Assert.AreEqual(results, true, "2, 3 ,4 ,5 ,6");


        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> cards = new List<int> { 14, 5, 4, 2, 3 };

            var results = Poker.PokerStraigth.isStraight(cards);
            Assert.AreEqual(results, true, "14, 5, 4 ,2, 3");

        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> cards = new List<int> { 7, 7, 12 ,11, 3, 4, 14 };

            var results = Poker.PokerStraigth.isStraight(cards);
            Assert.AreEqual(results, false, "7, 7, 12 ,11, 3, 4, 14");

        }

        [TestMethod]
        public void TestMethod4()
        {
            List<int> cards = new List<int> { 7, 3, 2 };

            var results = Poker.PokerStraigth.isStraight(cards);
            Assert.AreEqual(results, false, "7, 3, 2");

        }
        
    }
}
