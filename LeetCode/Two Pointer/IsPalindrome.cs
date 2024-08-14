using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Two_Pointer
{
    public partial class TwoPointer
    {
        public bool IsPalindrome(string s)
        {
            s = s.Trim().ToUpper();
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {

                while (i < j && !isAlphanum(s[i]))
                {
                    i++;
                }
                while (i < j && !isAlphanum(s[j]))
                {
                    j--;
                }
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        public bool isAlphanum(char c)
        {
            if (((c >= 65 && c <= 90) ||
                 (c >= 48 && c <= 57)))
            {
                return true;
            }
            return false;
        }

    }
}
