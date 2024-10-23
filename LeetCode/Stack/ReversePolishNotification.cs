using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public static partial class StackQuestions
    {
        public static void ReversePolishNotification() {

            var arr = new string[] { "2", "1", "+", "3", "+" };
            Stack<int> vs = new Stack<int>();


            foreach (var item in arr)
            {

                if (item != "+" & item != "-" & item != "*" & item != "/")
                {
                    vs.Push(Convert.ToInt32(item));
                }
                else {
                    var a = vs.Pop();
                    var b = vs.Pop();
                    var c = a + b;
                    vs.Push(c);
                }
            }

            Console.WriteLine(vs.Pop());



            
        
        }
    
    }
}
