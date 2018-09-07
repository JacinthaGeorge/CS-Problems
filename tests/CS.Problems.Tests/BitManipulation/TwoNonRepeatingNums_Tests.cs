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
    /// http://www.geeksforgeeks.org/find-two-non-repeating-elements-in-an-array-of-repeating-elements/
    /// </summary>
    [TestClass]
    public class TwoNonRepeatingNums_Tests
    {
        [TestMethod]
        public void TwoNonRepeatingNums_Smoke_Test()
        {
            CollectionAssert.AreEqual(new int[] { 7, 9 },
                TwoNonRepeatingNums.Find(new int[] { 2, 3, 7, 9, 11, 2, 3, 11 }));
        }
    }
}
