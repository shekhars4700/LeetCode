using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class PeakElement
    {
        public static int find(int[] nums) {
            int start = 0;
            int end = nums.Length - 1;
            int mid = -1;

            if (nums.Length == 1)
                return 1;

            while (start <= end) { 
               mid = start + (end - start) / 2;
                if (mid == 0)
                {
                    if (nums[mid + 1] < nums[mid])
                        return mid;
                    else
                        start = mid + 1;
                }                
                else if (mid == nums.Length - 1)
                {
                    if (nums[mid - 1] < nums[mid])
                        return mid;
                    else
                        end = mid - 1;
                }
                else if (nums[mid] > nums[mid - 1] && nums[mid + 1] < nums[mid])
                {
                    return mid;
                }
                else if (nums[mid] < nums[mid - 1])
                {
                    end = mid - 1;
                }
                else if (nums[mid] < nums[mid + 1]) {
                    start = mid + 1;
                }
            }
            return mid;
        }
    }
}
