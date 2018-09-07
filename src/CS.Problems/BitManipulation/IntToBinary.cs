﻿using System;
using System.Text;

namespace CS.Problems.BitManipulation
{
    public class IntToBinary
    {
        public static string GetBinary(int integer, int precision)
        {
            if(precision > sizeof(int) * 8)
            {
                throw new ArgumentOutOfRangeException();
            }

            var stringBuilder = new StringBuilder();

            for(int i = precision-1;i >=0; i--)
            {
                stringBuilder.Insert(0, (integer & 1) == 0 ? "0" : "1");
                integer >>= integer;
            }

            return stringBuilder.ToString();
        }
    }
}
