using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Backtracking
{
    public static  class PermutationWithBT
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<List<int>>();
            List<int> ip = nums.ToList();
            Solve(ip, 0, result);
            return null;
        }

        public static void Solve(List<int>ip, int start, List<List<int>> result)
        {
            if (start == ip.Count -1)
            {
                result.Add(ip.ToList());
                return;
            }
            
            for (int i = start; i < ip.Count; i++)
            {
                swap(start, i, ip);
                Solve(ip, start + 1, result);
                swap(start, i, ip);
            }
        }
        public static void swap(int start, int i, List<int> ip) {
            int temp = ip[i];
            ip[i] = ip[start];
            ip[start] = temp;
        }
    }
}
