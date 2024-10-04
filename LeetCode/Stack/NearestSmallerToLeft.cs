using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public static partial class StackQuestions
    {
        public static int[] NearestSmallerToLeftIndex()
        {
            int[] arr = new int[] { 6, 2, 5, 4, 5, 1, 6 };
            int[] oArr = new int[arr.Length];
            Stack<KeyValuePair<int, int>> vs = new Stack<KeyValuePair<int, int>>();


            for (int i = 0; i < arr.Length; i++)
            {
                if (vs.Count == 0)
                {
                    oArr[i] = -1;
                }
                else if (vs.Peek().Value < arr[i]) {
                    oArr[i] = vs.Peek().Key;
                }
                else if (vs.Peek().Value >= arr[i]) {
                    while (vs.Count != 0 && vs.Peek().Value >= arr[i]) {
                        vs.Pop();
                    }
                    if (vs.Count == 0)
                    {
                        oArr[i] = -1;
                    }
                    else {
                        oArr[i] = vs.Peek().Key; 
                    }
                }
                vs.Push(new KeyValuePair<int, int>(i,arr[i]));
            }
            foreach (var item in oArr.ToList())
            {
                Console.Write(item + " ");
            }

            return oArr;
        }
    }
}
