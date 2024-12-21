using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Backtracking
{
    public static  class Permutations
    {
        public static  IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<List<int>>();
            Solve(nums,new List<int> (), result);
            return (IList<IList<int>>)result;
        }

        public static void Solve(int[] ip, List<int> op, List<List<int>> result)
        {
            if (ip.Length == 0)
            {
                result.Add(op);
                return;
            }

            for (int i = 0; i < ip.Length; i++)
            {
                var newip = ip.Take(i).Concat(ip.Skip(i + 1)).ToArray();
                //op.Add(ip[i]);
                var newop = new List<int>(op);
                newop.Add(ip[i]);
                Solve(newip, newop, result);
            }
        }

        //public static IList<IList<int>> Permute(string str)
        //{
        //    var result = new List<List<int>>();
        //    Solve(nums, new List<int>(), result);
        //    return (IList<IList<int>>)result;
        //}

        //public static void Solve(string str, List<int> op, List<List<int>> result)
        //{
        //    if (ip.Length == 0)
        //    {
        //        result.Add(op);
        //        return;
        //    }

        //    for (int i = 0; i < ip.Length; i++)
        //    {
        //        var newip = ip.Take(i).Concat(ip.Skip(i + 1)).ToArray();
        //        //op.Add(ip[i]);
        //        var newop = new List<int>(op);
        //        newop.Add(ip[i]);
        //        Solve(newip, newop, result);
        //    }
        //}
    }
}
