﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS.Problems.Miscellaneous;

namespace CS.Problems.Tests.Miscellaneous
{
    [TestClass]
    public class ZigZag_Tests
    {
        private static int[] testArray =
            new int[] { 4, 3, 7, 8, 6, 2, 1 };

        [TestMethod]
        public void ZigZag_Smoke_Test()
        {
            var result = ZigZagOrderer.Order(testArray);
            CollectionAssert.AreEqual(new int[] { 3, 7, 4, 8, 2, 6, 1, }, result);
        }
    }
}
