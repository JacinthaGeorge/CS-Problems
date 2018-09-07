﻿using CS.Problems.DynamicProgramming.Matrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Problems.Tests.DynamicProgramming.Matrix
{
    /// <summary>
    /// Problem statement below
    /// http://www.geeksforgeeks.org/maximum-size-rectangle-binary-sub-matrix-1s/
    /// </summary>
    [TestClass]
    public class Max1sRectangle_Tests
    {
        [TestMethod]
        public void Max1sRectangle_Smoke_Test()
        {
            var testMatrix = new int[4, 4] {
                       {0, 1, 1, 0},
                       {1, 1, 1, 1},
                       {1, 1, 1, 1},
                       {1, 1, 0, 0}
                      };

            var result = Max1sRectangle
                .FindMax(testMatrix);

            Assert.AreEqual(8, result);
        }
    }
}
