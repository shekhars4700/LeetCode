using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public static partial class StackQuestions
    {
        public static void DailyTempratures()
        {
            int[] arr = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            int[] returnArr = new int[arr.Length];
            Stack<KeyValuePair<int, int>> kv = new Stack<KeyValuePair<int, int>>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (kv.Count == 0)
                {
                    returnArr[i] = 0;
                }
                else if (kv.Peek().Value > arr[i])
                {
                    returnArr[i] = kv.Peek().Key - i ;
                }
                else
                {
                    while (kv.Count != 0 && kv.Peek().Value <= arr[i])
                    {
                        kv.Pop();
                    }
                    if (kv.Count == 0)
                    {
                        returnArr[i] = 0;
                    }
                    else
                    {
                        returnArr[i] = kv.Peek().Key - i;
                    }
                }
                kv.Push(new KeyValuePair<int, int>(i, arr[i]));
            }

            foreach (var item in returnArr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
