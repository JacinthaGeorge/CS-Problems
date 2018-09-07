﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS.Problems.DynamicProgramming;
using System.Collections.Generic;

namespace CS.Problems.Tests.DynamicProgramming
{
    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/dynamic-programming-set-7-coin-change/
    /// </summary>
    [TestClass]
    public class CoinChangeProblems_Tests
    {
        /// <summary>
        /// Gets the minimum number of coins to fit in the amount 
        /// </summary>
        [TestMethod]
        public void MinCoinChange_Test()
        {
            int[] coins = { 25, 10, 5 };
            int amount = 30;

            var result = CoinChangeProblems.MinCoinChangeRecursive(amount, coins.Length, coins, new Dictionary<int, int>());

            Assert.AreEqual(result, 2);
        }


        /// <summary>
        /// Gets the maximum number of coins to fit in the amount 
        /// </summary>
        [TestMethod]
        public  void MaxCoinChange_Test()
        {
            int[] coins = { 1, 2, 3 };
            int amount = 29;

            var result = CoinChangeProblems.MinCoinChangeRecursive(amount, coins.Length, coins, new Dictionary<int, int>());

            Assert.AreEqual(result, 10);
        }
    }
}
