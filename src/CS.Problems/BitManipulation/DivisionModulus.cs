﻿using System;

namespace CS.Problems.BitManipulation
{
    /// <summary>
    /// Compute modulus division by power of 2 without a division operator.
    /// </summary>
    public class DivisionModulus
    {
        public static int GetModulus(int numerator, int denominator)
        {
            //check if denominator is a power of 2 before proceeding
            if((denominator & (denominator-1))!=0)
            {
                throw new ArgumentException("Denominator is not a power of two.");
            }

            return numerator & (denominator - 1);
        }
    }
}
