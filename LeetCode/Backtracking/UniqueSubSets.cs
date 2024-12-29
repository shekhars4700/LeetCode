using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Backtracking
{
    public static class UniqueSubSets
    {
        //Input: nums = [1,2,2]
        //Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            nums.ToList().Sort();
            Solve(result, nums, 0, new List<int>(), new HashSet<List<int>>());
            return result;
        }
        public static void Solve(IList<IList<int>> result, int[] nums, int idx, List<int> Curr, HashSet<List<int>> set)
        {

            //if(idx > nums.Length)
            //    return;
            if (!result.Contains(Curr))
            {
                result.Add(new List<int>(Curr));
                set.Add(new List<int>(Curr));
            }
            for (int i = idx; i < nums.Length; i++)
            {
                Curr.Add(nums[i]);
                Solve(result, nums, i + 1, Curr, set);
                Curr.RemoveAt(Curr.Count - 1);
            }
            
        }
    }
}
