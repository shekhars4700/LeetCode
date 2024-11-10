using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class FindInAlmostSortedArray
    {
        public static int findTarget(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid = -1;
            int res = -1;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (target < arr[mid])
                {
                    if (arr[mid] < end)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else if (arr[mid] < target)
                {
                    if (arr[mid] < end)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            return res;
        }
    }
}
