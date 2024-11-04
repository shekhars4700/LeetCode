using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class FindCeil
    {
        public static void find(int [] arr, int target) {
            int start = 0;
            int end = arr.Length - 1;
            int res = -1;
            int mid = -1;

            while (start <= end) {
                mid = start + (end - start) / 2;

                if (target == arr[mid])
                {
                    res = arr[mid];
                    Console.WriteLine(res);
                    break;
                }
                else if (arr[mid] < target)
                {

                    start = start + 1;
                }
                else {
                    res = arr[mid];
                    end = mid -1;
                }
            }
            Console.WriteLine(res);
        }
    }
}
