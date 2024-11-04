using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class FindTheMinimum
    {
        public static  int FindMin(int[] nums, int target)
        {
            int start = 0;
            int len = nums.Length;
            int end = len - 1;
            int index = -1;
            while (start <= end)
            {
                int mid = start + ((end - start) / 2);
                if (nums[mid] == target) {
                    index = mid;
                    break;
                }
                if (nums[start] <= nums[mid])
                {
                    if (target <= nums[mid] && target >= nums[start])
                    {
                        end = mid - 1;
                    }
                    else {
                        start = mid + 1;
                    }
                }
                else {
                    if (target >= nums[mid] && target < nums[end])
                    {
                        start = mid + 1;
                    }
                    else {
                        end = mid - 1;
                    }
                }
            }
            return index;
        }
    }
}
