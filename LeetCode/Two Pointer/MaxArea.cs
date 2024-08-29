using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Two_Pointer
{
    public partial class TwoPointer
    {
        public int MaxArea(int[] height)
        {
            int i = 0;
            int j = height.Length - 1;
            int maxarea = 0;
            while (i < j)
            {
                int area = 0;
                if (height[i] <= height[j])
                {
                    area = height[i] * j;
                    maxarea = maxarea > area ? maxarea : area;
                    i++;
                }
                else if (height[j] < height[i])
                {
                    area = height[j] * (j-1);
                    maxarea = maxarea > area ? maxarea : area;
                    j--;
                }
            }

            return maxarea;
        }
    }
}
