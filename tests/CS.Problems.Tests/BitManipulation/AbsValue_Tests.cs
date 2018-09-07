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
    /// http://www.geeksforgeeks.org/compute-the-integer-absolute-value-abs-without-branching/
    /// </summary>
    [TestClass]
    public class AbsValue_Tests
    {
        [TestMethod]
        public void AbsValue_Smoke_Test()
        {
            Assert.AreEqual(2, AbsValue.GetAbs(-2));
        }
    }
}
