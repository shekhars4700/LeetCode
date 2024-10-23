using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public partial class MediumSolution
    {

        //Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
        //You must write an algorithm that runs in O(n) time.
        public int LongestConsecutive(int[] nums)
        {
            int longestConsecutiveLength = 0;
            //Move Array to Dictionary
            Dictionary<int, bool> numsMap = new Dictionary<int, bool>();
            foreach (var num in nums)
            {
                if (!numsMap.ContainsKey(num))
                {
                    numsMap.Add(num, false);
                }
            }

            foreach (var num in nums)
            {
                int count = 0;
                int prevNum = num-1;
                if (!numsMap.ContainsKey(prevNum)) {
                    int nextNum = num + 1;
                    count += 1;
                    while (numsMap.ContainsKey(nextNum)) {
                        nextNum = nextNum + 1;
                        count += 1;
                    }
                    longestConsecutiveLength = Math.Max(longestConsecutiveLength, count);
                }
            }
            return longestConsecutiveLength;



















            //foreach (var num in nums)
            //{
            //    int max = 0;
            //    int nextNum = num + 1;
            //    while (numsMap.ContainsKey(nextNum) && numsMap[nextNum] == false) {
            //        max += 1;
            //        numsMap[nextNum] = true;
            //        nextNum += 1;
            //    }
            //    int prevNum = num - 1;
            //    while (numsMap.ContainsKey(prevNum) && numsMap[prevNum] == false)
            //    {
            //        max += 1;
            //        numsMap[prevNum] = true;
            //        prevNum -= 1;
            //    }

            //    longestConsecutiveLength = max > longestConsecutiveLength ? max : longestConsecutiveLength;
            //}
            return longestConsecutiveLength;
        }
    }
}
