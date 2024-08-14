using LeetCode.Medium;
using LeetCode.Two_Pointer;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)

        {
            Solution solution = new Solution();



            #region Medium
            MediumSolution mediumSolution = new MediumSolution();
            //mediumSolution.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });
            #endregion


            #region TWO POINTERS
            TwoPointer twoPointer = new TwoPointer();
            Console.WriteLine(twoPointer.IsPalindrome("Was it a car or a cat I saw?"));
            Console.WriteLine(twoPointer.IsPalindrome("tab a cat"));
            Console.WriteLine(twoPointer.IsPalindrome(",."));
            #endregion

        }
    }
}
