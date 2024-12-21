using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sliding_Window
{
    public static class SubArrayCOunt
    {
        public static int SubarraySum(int[] nums, int k)
        {
            int i = 0;
            int j = 0;
            int count = 0;
            int sum = 0;
            while (j < nums.Length)
            {
                sum = sum + nums[j];
                if (sum == k)
                {
                    Console.WriteLine(j);
                    count += 1;
                    j++;
                }
                if (sum < k)
                {
                    j++;
                }
                if (sum > k)
                {
                    while (sum > k)
                    {
                        sum -= nums[i];
                        i++;
                    }
                    if (sum == k) { 
                        count += 1;
                    }
                    j++;
                }
            }
            return count;
        }
    }
}
