using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sliding_Window
{
    public partial class SlidingWindow
    {
        public int LengthOfLongestSubstring(string s)
        {
            int i = 0;
            int j = 0;
            List<char> charList = new List<char>();
            int maxCount = 0;
            while (j < s.Length)
            {
                if (!charList.Contains(s[j]))
                {
                    charList.Add(s[j]);
                    j++;
                }
                else
                {
                    while (charList.Contains(s[i])) {
                        charList.Remove(s[i]);
                        i++;
                    }
                    j++;
                }
                maxCount = maxCount > charList.Count ? maxCount : charList.Count;
            }
            return maxCount;

        }
    }
}
