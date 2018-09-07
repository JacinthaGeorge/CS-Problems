﻿using CS.Problems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.Tests.DynamicProgramming
{
    /// <summary>
    /// Problem details below
    /// https://leetcode.com/problems/burst-balloons/#/description
    /// </summary>
    [TestClass]
    public class BurstBalloon_Tests
    {
        [TestMethod]
        public void BurstBalloon_Smoke_Test()
        {
            Assert.AreEqual(167, BurstBalloon.MaxCoins(new int[] { 3, 1, 5, 8 }));
        }
    }
}
