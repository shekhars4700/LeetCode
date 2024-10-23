using LeetCode.Medium;
using LeetCode.Recursion;
using LeetCode.Sliding_Window;
using LeetCode.Stack;
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
            SlidingWindow slidingWindow = new SlidingWindow();
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
            //Console.WriteLine(twoPointer.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));
            //Console.WriteLine(twoPointer.ThreeSum(new int[] { 0, 1, 1 }));
            //Console.WriteLine(twoPointer.ThreeSum(new int[] { 0, 0, 0,0 }));
            #endregion


            #region MaxArea
            //Console.WriteLine(twoPointer.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            //Console.WriteLine(twoPointer.MaxArea(new int[] { 1, 1 }));
            #endregion


            #endregion



            #region SlidingWindow
            //Console.WriteLine(slidingWindow.printFirstNegativeInteger(new long[] { -8, 2, 3, -6, 10 },5,2));

            // Console.WriteLine(slidingWindow.LengthOfLongestSubstring("abcabcbb"));

            #endregion



            #region Stack Questions

            //int[] arr = new int[] { 6, 2, 5, 4, 5, 1, 6 };
            //var right = StackQuestions.NearestSmallerToRightIndex();

            //Console.WriteLine("*******************************************************************");

            //var left = StackQuestions.NearestSmallerToLeftIndex();
            //Console.WriteLine("********************* WIDTH ARARRRRRRRRR****************************");

            //int[] width = new int[right.Length];
            //for (int i = 0; i < right.Length; i++)
            //{
            //    width[i] = right[i] - left[i] - 1;
            //}

            //foreach (var item in width)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("********************* WIDTH ARARRRRRRRRR****************************");

            //int[] area = new int[width.Length];
            //for (int i = 0; i < width.Length; i++)
            //{
            //    area[i] = width[i] * arr[i];
            //}

            //foreach (var item in area)
            //{
            //    Console.Write(item + " ");
            //}

            //StackQuestions.NearestGreaterToRight();
            //StackQuestions.ValidParenthesis();
            //StackQuestions.ReversePolishNotification();
            //StackQuestions.DailyTempratures();
            #endregion

            #region Recursion
            //Console.WriteLine(0);
            //Console.WriteLine(1);
            //Console.WriteLine(Recursion.Fib(5));
            //Recursion.insertionSort();
            //Recursion.SortAnStack();
            //Console.WriteLine(LeetCode.Recursion.KthSymbol.Solve(3,4));

            PermiutationWithSpace.main();
            #endregion

        }
    }
}
