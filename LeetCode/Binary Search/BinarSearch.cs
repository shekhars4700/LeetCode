using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class BinarSearch
    {
        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = start + (end - start) / 2;
            int result = -1;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (target == nums[mid])
                {
                    result = mid;
                    break;
                }
                else if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else if (target > nums[mid])
                {
                    start = mid + 1;
                }
            }
            return result;
        }


        public static void SearchUsingRec(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = start + (end - start / 2);
            SearchUsingRecImpl(nums,target,mid,start,end);
        }

        public static void SearchUsingRecImpl(int[] nums, int target, int mid, int start, int end)
        {
            if (target == nums[mid]) {
                Console.WriteLine(mid);
                return;
            }
            if (target < nums[mid])
            {
                end = mid - 1;
            }
            else {
                start = mid + 1;
            }
            mid = start + (end - start / 2);
            SearchUsingRecImpl(nums, target, mid, start, end);
        }
    }
}
