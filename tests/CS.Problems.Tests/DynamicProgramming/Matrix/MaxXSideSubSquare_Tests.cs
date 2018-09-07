﻿using CS.Problems.DynamicProgramming.Matrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Problems.Tests.DynamicProgramming.Matrix
{
    /// <summary>
    /// Problem statement below
    ///http://www.geeksforgeeks.org/given-matrix-o-x-find-largest-subsquare-surrounded-x/
    /// </summary>
    [TestClass]
    public class MaxXSideSubSquare_Tests
    {
        [TestMethod]
        public void MaxXSideSubSquare_Smoke_Test()
        {
            var testMatrix = new char[,]  {
                     {'X', 'O', 'X', 'X', 'X', 'X'},
                     {'X', 'O', 'X', 'X', 'O', 'X'},
                     {'X', 'X', 'X', 'O', 'O', 'X'},
                     {'O', 'X', 'X', 'X', 'X', 'X'},
                     {'X', 'X', 'X', 'O', 'X', 'O'},
                     {'O', 'O', 'X', 'O', 'O', 'O'},
                    };

            var result = MaxXSideSubSquare
                .FindMax(testMatrix);

            Assert.AreEqual(4, result);
        }
    }
}
