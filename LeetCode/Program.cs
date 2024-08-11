using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)

        {
            Solution solution = new Solution();
            Console.WriteLine(solution.MajorityElement(new int[] { 3, 2, 3 }));
            Console.WriteLine(solution.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }
    }
}
