using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Backtracking
{
    public static class PalindromPartitioning
    {
        public static IList<IList<string>> Partition(string s)
        {

            IList<IList<string>> result = new List<IList<string>>();
            Solve(s, result, 0, new List<string>());
            return result;
        }

        public static void Solve(string s, IList<IList<string>> result, int idx, IList<string> Curr)
        {
            if (idx == s.Length)
            {
                result.Add(new List<string>(Curr));
                return;
            }

            for (int i = idx; i < s.Length; i++)
            {
                if (IsPlanindrome(s, idx, i))
                {
                    Curr.Add(s.Substring(idx, i - idx + 1));
                    Solve(s, result, i + 1, Curr);
                    Curr.RemoveAt(Curr.Count - 1);
                }
            }
        }


        public static bool IsPlanindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
