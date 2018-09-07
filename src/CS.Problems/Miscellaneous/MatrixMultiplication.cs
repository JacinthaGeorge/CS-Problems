﻿using System;

namespace CS.Problems.Miscellaneous
{
    public class MatrixMultiplication
    {
        public static int[,] Multiply(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                throw new Exception("Matrice A don't have same number of rows as the columns of matrix B.");
            }

            var n = b.GetLength(0);

            var result = new int[n, n];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }
    }
}
