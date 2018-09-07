﻿using CS.Problems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.Tests.DynamicProgramming
{
    [TestClass]
    public class WordBreak_Tests
    {
        [TestMethod]
        public void WordBreak_Smoke_Test()
        {
            var dictionary = new HashSet<string>() {"mobile","samsung","sam",
                            "sung","man","mango",
                           "icecream","and","go","i","like","ice","cream"};

            Assert.AreEqual(true, WordBreakProblem.CanBreak(dictionary, "ilikesamsung"));
            Assert.AreEqual(false, WordBreakProblem.CanBreak(dictionary, "iiiiiiiicrack"));
        }
    }
}
