using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Recursion
{
    public static class Print_N_Bit
    {
        public static void main() {
            int n = 3;
            int ones = 1;
            int zeros = 0;
            n = n - ones;
            string op = "1";

            solve(n,ones,zeros,op);
        }

        public static void solve(int n , int ones, int zeros,string op) {
            if (n == 0) {
                Console.WriteLine(op);
                return;
            }

            if (ones > zeros)
            {
                string op1 = op + "1";
                solve(n - 1, ones + 1, zeros, op1);

                string op2 = op + "0";
                solve(n - 1, ones, zeros + 1, op2);
            }
            else {
                string op1 = op + "1";
                solve(n - 1, ones + 1, zeros, op1);
            }
        
        }

    }
}
