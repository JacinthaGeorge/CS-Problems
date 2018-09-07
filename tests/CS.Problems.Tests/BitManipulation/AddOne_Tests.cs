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
    /// http://www.geeksforgeeks.org/add-1-to-a-given-number/
    /// </summary>
    [TestClass]
    public class AddOne_Tests
    {
        [TestMethod]
        public void AddOne_Smoke_Test()
        {
            Assert.AreEqual(13, AddOne.Find(12));
        }
    }
}
