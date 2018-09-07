﻿using CS.Problems.DynamicProgramming.Maximizing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.Tests.DynamicProgramming.Maximizing
{
    /// <summary>
    /// Problem details below
    /// http://www.geeksforgeeks.org/dynamic-programming-set-14-variations-of-lis/
    /// </summary>
    [TestClass]
    public class LongestChain_Tests
    {
        [TestMethod]
        public void GetLongest_Smoke_Test()
        {
            Assert.AreEqual(3, LongestChain.GetLongest(new List<int[]>() { new int[] { 5, 24 },
                                    new int[]{ 15, 25 },
                                    new int[]{ 27, 40 },
                                    new int[]{ 50, 60 }
            }));
        }
    }
}
