﻿using CS.Problems.BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.Tests.BitManipulation
{
    /// <summary>
    /// Problem details below
    /// http://www.geeksforgeeks.org/swap-all-odd-and-even-bits/
    /// </summary>
    [TestClass]
    public class SwapOddEvenBits_Tests
    {
        [TestMethod]
        public void SwapOddEvenBits_Smoke_Test()
        {
            Assert.AreEqual(43, SwapOddEvenBits.Swap(23));
        }
    }
}
