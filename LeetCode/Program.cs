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

            #region Palindrom
            //Console.WriteLine(twoPointer.IsPalindrome("Was it a car or a cat I saw?"));
            //Console.WriteLine(twoPointer.IsPalindrome("tab a cat"));
            //Console.WriteLine(twoPointer.IsPalindrome(",."));
            #endregion


            #region TwoSum Sorted Array
            //Console.WriteLine(twoPointer.TwoSum(new int[] { 2, 7, 11, 15 },9));
            //Console.WriteLine(twoPointer.TwoSum(new int[] { 2, 3, 4 }, 6));
            //Console.WriteLine(twoPointer.TwoSum(new int[] { -1, 0 }, -1));
            #endregion

            #region 3Sum 
            Console.WriteLine(twoPointer.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));
            Console.WriteLine(twoPointer.ThreeSum(new int[] { 0, 1, 1 }));
            Console.WriteLine(twoPointer.ThreeSum(new int[] { 0, 0, 0,0 }));
            #endregion


            #endregion

        }
    }
}
