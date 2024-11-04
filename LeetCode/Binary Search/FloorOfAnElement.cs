using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class FloorOfAnElement
    {
        public static void findFloor(int[] arr, int target) {
            int start = 0;
            int end = arr.Length - 1;
            int mid = 0;
            int res = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                mid = start + (end - start) / 2;
                if (arr[mid] <= target)
                {
                    res = arr[mid];
                    start = mid + 1;
                }
                else {
                    end = mid - 1;
                }
            }
            Console.WriteLine(res);
        }
    }
}
