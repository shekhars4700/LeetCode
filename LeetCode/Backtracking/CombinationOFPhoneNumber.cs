using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Backtracking
{
    public static  class CombinationOFPhoneNumber
    {
        public static IList<string> LetterCombinations(string digits)
        {
            if (digits == "")
                return new List<string>() { ""};
            Dictionary<char, string> map = new Dictionary<char, string>();
            map.Add('2', "abc");
            map.Add('3', "def");
            map.Add('4', "ghi");
            map.Add('5', "jhk");
            map.Add('6', "mno");
            map.Add('7', "pqrs");
            map.Add('8', "tuv");
            map.Add('9', "wxyz"); ;
            List<string> result = new List<string>();
            Solve(digits, map, 0, "", result);
            return result;
        }

        public static void Solve(string digits, Dictionary<char, string> map, int idx, string temp, List<string> result)
        {
            if (idx == digits.Length)
            {
                result.Add(temp);
                return;
            }
            if (idx > digits.Length)
            {
                return;
            }

            char ch = digits[idx];
            string str = map[ch];

            for (int i = 0; i < str.Length; i++)
            {
                temp += str[i];
                Solve(digits, map, idx + 1, temp, result);
                temp = temp.Remove(temp.Length - 1);
            }
        }
    }
}
