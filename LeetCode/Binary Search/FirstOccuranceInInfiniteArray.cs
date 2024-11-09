using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class FirstOccuranceInInfiniteArray
    {
        public static int find(int[] arr, int target) {
            int res = -1;
            int start = 0;
            int end = start + 1;
            while (start <= end) {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    res = mid;
                    end = mid - 1;
                }
                else if (target > arr[end] && target > arr[start])
                {
                    start = end;
                    end = end * 2;
                }
                else if (target <= arr[end] && target > arr[start]) {
                    if (target < arr[mid])
                    {
                        end = mid - 1;
                    }
                    else {
                        start = mid + 1;
                    }
                }
            }
            return res; 
        }
    }
}
