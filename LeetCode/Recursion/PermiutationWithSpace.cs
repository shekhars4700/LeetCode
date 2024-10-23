using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Recursion
{
    public static  class PermiutationWithSpace
    {
        public static void main() {
            string input = "abc";
            string output = "";

            // setup for the choices
            input = input.Remove(0,1);
            output = "a";
            solve(input, output);
        }

        public static void solve(string input , string output)
        {
            if (input.Length == 0) {
                Console.WriteLine(output);
                return;
            }

            // setup Two Outputs
            string ouput1 = output + input[0];
            string ouput2 = output + " " + input[0];

            // smaller input
            input = input.Remove(0, 1);

            // call recursivly for both the inputs
            solve(input, ouput1);
            solve(input, ouput2);
        }


    }
}
