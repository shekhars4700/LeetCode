using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public static partial class StackQuestions
    {
        public static void NearestGreaterToLeft() {
            int[] arr = new int[] { 100,80,60,70,60,75,85};
            int[] oarr = new int[arr.Length];
            Stack<KeyValuePair<int,int>> vs = new Stack<KeyValuePair<int, int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (vs.Count == 0)
                {
                    oarr[i] = 1;
                }
                else if (vs.Peek().Value > arr[i])
                {
                    oarr[i] =  i - vs.Peek().Key ;
                }
                else if (vs.Peek().Value <= arr[i]) {
                    while (vs.Count != 0 && vs.Peek().Value <= arr[i]) {
                        vs.Pop();
                    }
                    if (vs.Count == 0)
                    {
                        oarr[i] = 1;
                    }
                    else {
                        oarr[i] = i - vs.Peek().Key;
                    }
                }
                vs.Push(new KeyValuePair<int, int>(i, arr[i]));
            }
            foreach (var item in oarr.ToList())
            {
                Console.WriteLine(item);
            }
        }
    }
}
