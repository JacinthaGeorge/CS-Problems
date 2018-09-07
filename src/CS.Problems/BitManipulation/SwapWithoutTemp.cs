﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.BitManipulation
{
    /// <summary>
    /// Problem details below
    /// http://www.geeksforgeeks.org/swap-two-numbers-without-using-temporary-variable/
    /// </summary>
    public class SwapWithoutTemp
    {
        public static void Swap(ref int x, ref int y)
        {
            //based on the properties of XOR
            //if a^b=c => a^c=b and b^c=a

            var z = x ^ y;

            x = z ^ x;
            y = z ^ y;
        }
    }
}
