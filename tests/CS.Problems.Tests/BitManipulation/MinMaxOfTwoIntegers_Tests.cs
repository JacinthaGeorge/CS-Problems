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
    /// http://www.geeksforgeeks.org/compute-the-minimum-or-maximum-max-of-two-integers-without-branching/
    /// </summary>
    [TestClass]
    public class MinMaxOfTwoIntegers_Tests
    {
        [TestMethod]
        public void MinMaxOfTwoIntegers_Smoke_Test()
        {
            Assert.AreEqual(6, MinMaxOfTwoIntegers.FindMin(15, 6));
            Assert.AreEqual(15, MinMaxOfTwoIntegers.FindMax(15, 6));
        }
    }
}
