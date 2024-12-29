using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Backtracking
{
    public static class NonDecreasingSubSequence
    {
        public static IList<IList<int>> FindSubsequences(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Solve( nums,0,new List<int> (), result);
            return result;  
        }

        public static void Solve( int[] nums, int idx, List<int> curr, List<IList<int>> result)
        {
            if (curr.Count >= 2)
                result.Add(new List<int>(curr));

            if(idx == nums.Length)
                return;
            
            HashSet<int> visited = new HashSet<int>();
            for (int i = idx; i < nums.Length; i++)
            {
                if ((curr.Count == 0 || curr[curr.Count - 1] <= nums[i]) && !visited.Contains(nums[i])) 
                {
                    curr.Add(nums[i]);
                    Solve( nums, i + 1, curr, result);
                    if(curr.Count > 0)
                        curr.RemoveAt(curr.Count - 1);
                }
                visited.Add(nums[i]);
            }
        }
    }
}
