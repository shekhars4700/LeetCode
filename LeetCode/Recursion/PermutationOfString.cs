using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Recursion
{
    public static  class PermutationOfString
    {
        public static void Permute(string str)
        {
            var result = new List<string>();
            Solve(str, "", result);
           var abc = result;
        }

        private static void Solve(string str, string v, List<string> result)
        {
            if (str.Length == 0) { 
                   result.Add(v);
            }

            for (int i = 0; i < str.Length; i++)
            {
                var newIp = str.Substring(0,i) + str.Substring(i+1);
                var newOP = v + str[i];
                Solve(newIp, newOP, result);
            }

        }
    }
}
