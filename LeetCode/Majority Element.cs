using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        //169. Majority Element
        //Given an array nums of size n, return the majority element.
        //The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> elementCountDic = new Dictionary<int, int>();
            int max = 1;
            int majorityElement = nums[0];
            foreach (var num in nums)
            {
                if (max > (nums.Length / 2))
                {
                    return majorityElement;
                }

                if (elementCountDic.ContainsKey(num))
                {
                    elementCountDic.Add(num, 1);
                }
                else
                {
                    elementCountDic[num] += 1;
                    if (elementCountDic[num] >= max)
                    {
                        max = elementCountDic[num];
                        majorityElement = num;
                    }
                }
            }
            return majorityElement;
        }
    }
}
