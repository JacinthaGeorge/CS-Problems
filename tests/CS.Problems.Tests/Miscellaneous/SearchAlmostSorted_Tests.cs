﻿using CS.Problems.Miscellaneous;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Problems.Tests.Miscellaneous
{

    [TestClass]
    public class SearchAlmostSorted_Tests
    {
        [TestMethod]
        public void Search_Almost_Sorted_Smoke_Test()
        {
            var test = new int[] { 10, 3, 40, 20, 50, 80, 70 };

            Assert.AreEqual(2, SearchAlmostSorted.Search(test, 40));
            Assert.AreEqual(-1, SearchAlmostSorted.Search(test, 100));

        }
    }
}
