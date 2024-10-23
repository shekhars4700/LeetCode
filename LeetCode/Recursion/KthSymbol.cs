using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Recursion
{
    public static class KthSymbol
    {

        public static int Solve(int n, int k) {
            if (n == 1 || k== 1) return 0;
            int mid = (int)Math.Pow(2, n - 1)/2;
            if (k <= mid)
            {
                return (Solve(n - 1, k));
            }
            else {
                return 1- (Solve(n - 1, k-mid));
            }
        }

    }
}
