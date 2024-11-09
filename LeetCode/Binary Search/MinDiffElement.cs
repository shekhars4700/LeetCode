using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class MinDiffElement
    {
        public static int find(int[] arr, int target) {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end) {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    return 0;
                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else if (arr[mid] < target) {
                    start = mid + 1;
                }

            }
            return Math.Min(Math.Abs(arr[start] - target), Math.Abs(arr[end] - target));

        }
    }
}
