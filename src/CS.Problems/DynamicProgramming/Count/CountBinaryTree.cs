﻿using System.Collections.Generic;

namespace CS.Problems.DynamicProgramming.Count
{
    /// <summary>
    /// Problem statement below
    /// http://www.geeksforgeeks.org/find-all-possible-trees-with-given-inorder-traversal/
    /// </summary>
    public class CountBinaryTree
    {
        public static int Count(int n)
        {
            return Count(0, n, new Dictionary<string, int>());
        }

        /// <summary>
        /// If we draw the BTs ignoring symmetrical duplicates
        /// we will see the count will be equal
        /// to n'th Catalan number
        /// And is same as the number of ways we can 
        /// parenthesize an expression
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static int Count(int start, int end, Dictionary<string, int> cache)
        {
            if (start > end)
            {
                return 0;
            }

            //base case
            if (start == end)
            {
                return 1;
            }

            var cacheKey = $"{start}-{end}";

            if(cache.ContainsKey(cacheKey))
            {
                return cache[cacheKey];
            }


            var count = 0;

            //break in to left & right
            for (int i = start; i < end; i++)
            {
                count += Count(start, i, cache)
                         * Count(i + 1, end, cache);
            }

            cache.Add(cacheKey, count);

            return count;
        }
    }
}
