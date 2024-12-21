using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class RotatedArray
    {

        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int len = nums.Length;
            int end = len - 1;
            int index = -1;


            while (start <= end)
            {
                int mid = start + ((end - start) / 2);
                if (nums[mid] == target)
                {
                    index = mid;
                    break;
                }




            




            }




            return index;
        }




    }
}
