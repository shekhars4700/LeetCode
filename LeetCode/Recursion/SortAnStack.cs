using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class Recursion5
    {
        public static void SortAnStack()
        {
            Stack<int> vs = new Stack<int>();
            vs.Push(2);
            vs.Push(0);
            vs.Push(1);
            vs.Push(5);

            var ans = Sort(vs);
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }

        public static Stack<int> Sort(Stack<int> vs) {
            if (vs.Count == 1) {
                return vs;
            }
            var element = vs.Pop();
            Sort(vs);
            Insert(vs, element);
            return vs;
        }

        public static void Insert(Stack<int> vs, int ele) {
            if (vs.Count == 0 || vs.Peek() <= ele) {
                vs.Push(ele);
                return;
            }
            int temp = vs.Pop();
            Insert(vs, ele);
            vs.Push(temp);
        }
    }
}
