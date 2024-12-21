using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Backtracking
{
    public static class CombinationSumUsingRecc
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> ans = new List<IList<int>>();
            //FindCombinations(0, target, new List<int>(), candidates, ans);
            FindCombinations(0, candidates, target, ans, new List<int>());
            return (IList<IList<int>>)ans;
        }

        private static void FindCombinations(int index, int[] arr, int target, List<IList<int>> ans, List<int> ds)
        {
            if (target == 0)
            {
                ans.Add(new List<int>(ds));
                return;
            }

            // If index is out of bounds or target becomes negative, return
            if (index >= arr.Length || target < 0)
            {
                return;
            }

            if (arr[index] <= target)
            {
                ds.Add(arr[index]);
                FindCombinations(index, arr, target - arr[index], ans, ds);
                ds.RemoveAt(ds.Count - 1);
            }
            FindCombinations(index + 1, arr, target, ans, ds);
        }


        private static void FindCombinations(int index, int target, List<int> current, int[] candidates, List<IList<int>> results)
        {
            // Base case: If the target is zero, add the current combination to results
            if (target == 0)
            {
                results.Add(new List<int>(current));
                return;
            }

            // If index is out of bounds or target becomes negative, return
            if (index >= candidates.Length || target < 0)
            {
                return;
            }

            if (candidates[index] <= target)
            {
                // Include the current candidate and recurse with a new list
                var newList = new List<int>(current) { candidates[index] };
                FindCombinations(index, target - candidates[index], newList, candidates, results);

                // Exclude the current candidate and move to the next index
                FindCombinations(index + 1, target, new List<int>(current), candidates, results);
            }
        }
    }
}
