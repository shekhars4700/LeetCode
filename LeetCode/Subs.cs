using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Subs
    {
        public static string AddSpaces(string s, int[] spaces)
        {
            int count = spaces[0];
            int index = 0;
            string s2 = s.Substring(0, count);
            int j = 0;
            int i = 0;
            while (j < s.Length) {
                index += 1;
                if (index == spaces.Length)
                {
                    s2 += " " + s.Substring(j); 
                    break;
                }
                s2 += " ";
                j = spaces[index];
                i = spaces[index -1];
                count =  j - i;
                s2 += s.Substring(i, count);
            }

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (i == count)
            //    {
            //        s2 += " ";
            //        index += 1;
            //        if (index < spaces.Length)
            //            count = spaces[index];
            //    }
            //    else
            //    {
            //        s2 += s[i];
            //    }
            //}
            return s2;
        }
    }
}
