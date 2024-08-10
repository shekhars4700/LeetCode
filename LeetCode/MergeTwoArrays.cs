using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MergeTwoArrays
    {
        static int[] nums1 = { 0 };
        static int[] nums2 = { 1};
        static int m = 0;
        static int n = 1;

        public static void Merge()
        {
            int last = nums1.Length;
            for (; m > 0 & n > 0; last--)
            {
                if (nums1[m - 1] >= nums2[n - 1])
                {
                    nums1[last - 1] = nums1[m - 1];
                    m--;
                }
                else if (nums1[m - 1] < nums2[n - 1])
                {
                    nums1[last - 1] = nums2[n - 1];
                    n--;
                }
            }

            while (n > 0)
            {
                nums1[last-1] = nums2[n - 1];
                 n--;
                last--;
            }
            display(nums1);
        }

        public static void display(int [] result) {
            foreach (var item in result)
            {
                Console.Write(" " + item + ",");
            }
        
        }
    }
}
