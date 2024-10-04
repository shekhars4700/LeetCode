using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public static  partial  class StackQuestions
    {
        public static long[] nextLargerElement(long[] arr, int n) {

            long[] resultSet = new long[n];
            var s = new Stack<long>();


            for (int i = n - 1; i >= 0; i--)
            {
                if (s.Count == 0) {
                    resultSet[i] = -1;
                }
                if (s.Any() && s.Peek() > arr[i])
                {
                    resultSet[i] = s.Peek();
                }
                else if (s.Any() && s.Peek() < arr[i]) {
                    while (s.Count > 0 && arr[i] >= s.Peek()) {
                        s.Pop();
                    }
                    if (s.Count == 0)
                    {
                        resultSet[i] = -1;
                    }
                    else {
                        resultSet[i] = s.Peek();
                    }
                }
                s.Push(arr[i]);
            }
            return resultSet;
        }

    }
}
