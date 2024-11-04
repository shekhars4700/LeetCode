using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class FirstnLastElement
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = start + ((end - start) / 2);
            int[] returnArr = new int[2];
            int first = -1;
            int last = -1;

            while (start <= end) {
                mid = start + ((end - start) / 2);

                if (nums[mid] == target) {
                    first = mid;
                    end = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    start = mid +  1;
                    
                }
                else if (nums[mid] > target) {
                    end = mid - 1;
                }
            }
            returnArr[0] = first;
            start = 0;
            end = nums.Length - 1;
            while (start <= end)
            {
                mid = start + ((end - start) / 2);
                if (nums[mid] == target)
                {
                    last = mid;
                    start = mid + 1;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;

                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
            }
            returnArr[1] = last;
            return returnArr;
        }
    }
}
