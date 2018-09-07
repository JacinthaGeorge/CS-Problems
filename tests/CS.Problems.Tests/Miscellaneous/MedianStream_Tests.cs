﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CS.Problems.Miscellaneous;


namespace CS.Problems.Tests.Miscellaneous
{
    [TestClass]
    public class MedianStream_Tests
    {
        [TestMethod]
        public void MedianOfStream_Smoke_Test()
        {
            var medianStream = new MedianStream();

            var stream = new List<int> { 5, 15, 1, 3 };
            var median = medianStream.GetMedian();
            foreach (var item in stream)
            {
                medianStream.Add(item);
                median = medianStream.GetMedian();
            }
      
            Assert.AreEqual(4, medianStream.GetMedian());
        }
    }
}
