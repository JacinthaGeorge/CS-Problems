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
    /// http://www.geeksforgeeks.org/find-nth-magic-number/
    /// </summary>
    [TestClass]
    public class MagicNumber_Tests
    {
        [TestMethod]
        public void MagicNumber_Smoke_Test()
        {
            Assert.AreEqual(130, MagicNumber.FindNth(5));
        }
    }
}
