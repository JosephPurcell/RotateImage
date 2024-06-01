using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateImage
{
    public class Solution
    {
        // Leetcode stats
        // Runtime 86ms - Beats 98.42% of users with C#
        // Memory 45.86MB - Beats 35.22% of users with C#

        public void Rotate(int[][] matrix)
        {
            // algorithm to rotate a matrix
            // rows -> columns
            // row 0 -> column N, left to right becomes top to bottom
            // row N -> column 0

            int length = matrix[0].Length;
            int[][] rotatedMtx = new int[length][];
            for (int i = 0; i < length; i++)
            {
                rotatedMtx[i] = new int[length];
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    rotatedMtx[j][length - 1 - i] = matrix[i][j];
                }
            }
            for (int i = 0; i < length; i++)
            {
                matrix[i] = rotatedMtx[i];
            }
        }
    }
}
