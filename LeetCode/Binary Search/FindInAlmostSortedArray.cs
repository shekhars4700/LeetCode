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
            int index = -1;
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end) {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target) {
                    index = mid;
                    break;
                }
                else if (mid + 1 <= end && arr[mid+ 1] == target)
                {
                    index = mid + 1;
                    break;
                }
                else if (mid -1 >= start && arr[mid - 1] == target)
                {
                    index = mid - 1;
                    break;
                }
                if (arr[mid] <= target)
                {
                    start = mid + 1;
                }
                else {
                    end = mid - 1;
                }
            }

            return index;
        }
    }
}
