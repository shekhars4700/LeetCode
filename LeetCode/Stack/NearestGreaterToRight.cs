using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public static partial class StackQuestions
    {
        public static void NearestGreaterToRight()
        {
            int[] arr = new int[] { 1, 3,2,4};
            int[] result= new int[arr.Length]; // 3,4,4,-1
            Stack<int> vs = new Stack<int>();


            for (int i = arr.Length -1; i >= 0; i--)
            {
                if (vs.Count == 0)
                {
                    result[i] = -1;
                }
                else if (vs.Peek() > arr[i])
                {
                    result[i] = vs.Peek();
                }
                else if (vs.Peek() <= arr[i]) {
                    while (vs.Count != 0 && vs.Peek() <= arr[i]) {
                        vs.Pop();   
                    }
                    if (vs.Count == 0)
                    {
                        result[i] = -1;
                    }
                    else
                    {
                        result[i] = vs.Peek();
                    }
                }
                vs.Push(arr[i]);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }









        }
    }
}
