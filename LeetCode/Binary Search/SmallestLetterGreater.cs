using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class SmallestLetterGreater
    {
        public static char NextGreatestLetter(char[] letters, char target) {
            int start = 0;
            int end = letters.Length;
            char res = letters[0];
            int mid = -1;
            while (start <= end) {
                mid = (start + (end - start)) / 2;
                 if (letters[mid] > target)
                {
                    res = letters[mid];
                    end = mid - 1;
                }
                else if (letters[mid] <= target) {
                    start = mid + 1;
                }
            }

            return res;



        }
    }
}
