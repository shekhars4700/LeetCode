using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class MinimumNoOfPages
    {

        public static int findMax(int[] arr, out int sum) {
            int max = -1;
            sum = 0;
            foreach (int i in arr)
            {
                sum += i;
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        public static int find(int[] arr, int h) {
            int sum = 0;
            int start = findMax(arr, out sum); ;
            int end = sum;
            int res = -1;
            int mid = -1;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (IsValid(h, arr, mid)) {
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

        public static bool IsValid(int h, int []arr, int mid){
            int student = 1;
            int pages = 0;
            foreach(int i in arr)
            {
                pages = pages + i;
                if (pages > mid) {
                    student += 1;
                    pages = i;
                }
                if (student > h) { 
                    return false;
                }
            }
            return true;
        }
    }
}
