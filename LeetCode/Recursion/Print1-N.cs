using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class Recursion2
    {
        public static void print1toN() {
            int n = 7;
            print(n);
        }
        public static void print(int n) {
            if (n == 1) {
                Console.WriteLine(1);
                return;
            }
            Console.WriteLine(n);
            print(n - 1);
            
        }
    }
}
