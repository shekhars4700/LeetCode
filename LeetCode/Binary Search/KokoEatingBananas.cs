using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class KokoEatingBananas
    {
        public static int MinEatingSpeed(int[] arr, int h)
        {
            int sum = 0;
            int start = 1; 
            int end = arr.Max();
            int res = -1;
            int mid = -1;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (IsValid(h, arr, mid))
                {
                    res = mid;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return res;
        }

        public static bool IsValid(int h, int[] arr, int mid)
        {
            int hours = 0;
            foreach (int i in arr)
            {
                hours += (i + mid - 1) / mid;  // Calculate the required hours per pile at speed `mid`
            }
            return hours <= h;
        }
    }
}
