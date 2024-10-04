using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public static partial class StackQuestions {
        public static void ValidParenthesis()
        {
            string s = "[]]]]]]]][]]]]]]]]]]";
            Dictionary<char, char> parDict = new Dictionary<char, char>();
            parDict.Add(')', '(');
            parDict.Add(']', '[');
            parDict.Add('}', '{');

            Stack<char> vs = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    vs.Push(item);
                }
                else if (vs.Count == 0 && parDict.ContainsKey(item)) {
                    Console.WriteLine("False");
                }
                else if (vs.Count != 0 && parDict.ContainsKey(item)) {
                    if (vs.Peek() == parDict.GetValueOrDefault(item)) {
                        vs.Pop();
                    }
                    else {
                        Console.WriteLine("False");
                    }
                }
            }
            Console.WriteLine("true");
        }
    }
}
