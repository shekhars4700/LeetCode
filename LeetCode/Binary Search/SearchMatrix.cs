using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class SearchMatrix
    {
        public static bool Search(int[][] matrix, int target) {
            int m = matrix.Length;
            int n = matrix[0].Length;
            bool res = false;
            int j = n-1;
            int i = 0;
            while (i >= 0 && i < m && j >= 0 && j < n) {

                if (matrix[i][j] == target)
                {
                    return true;
                }
                else if (matrix[i][j] > target)
                {
                    j = j - 1;
                }
                else if (matrix[i][j] < target) {
                    i = i + 1;
                }
            }
            return res;
        }
    }
}
