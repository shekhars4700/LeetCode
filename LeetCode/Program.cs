﻿using LeetCode.Binary_Search;
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
            //RainWaterTrapping.Trap(new int[] {3,0,0,2,0,4});
            //MaximumAreaInHistogram.main();

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

            //PermiutationWithSpace.main();

            //Print_N_Bit.main();

            #endregion


            #region  Binary Search
            //BinarSearch.SearchUsingRec(new int[] { 0},0);
            //FirstnLastElement.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8);
            //Console.WriteLine(FindTheMinimum.FindMin(new int[] { 3, 4, 5, 6, 1, 2 }, 2));
            //FindCeil.find(new int[] {1,2,3,5,8,10,10,12}, 9);
            //FindCeil.find(new int[] { 1, 2, 3, 5, 6, 7, 8, 8 }, 4);
            //Console.WriteLine(SmallestLetterGreater.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'a'));

            //Console.WriteLine(FirstOccuranceInInfiniteArray.find(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 }, 1));
            //Console.WriteLine(MinDiffElement.find(new int[] { 1,3,5,8,10,15},12));

            //Console.WriteLine(PeakElement.find(new int[] { 1, 2 }));
            //Console.WriteLine(PeakElement.find(new int[] { 2, 1 }));
            //Console.WriteLine(PeakElement.find(new int[] { 1, 2, 1, 3, 5, 6, 4 }));

            Console.WriteLine(SearchMatrix.Search(new int[][]
            {
                new int[] {1,3,5,7},
                new int[] {10, 11, 16, 20},
                new int[] {23, 30, 34, 60}
            },13));


            #endregion

        }
    }
}
