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
            int res = 0, area = 0, left = 0, right = height.Length - 1;


            while (left < right)
            {

                area = (Math.Min(height[left], height[right])) * (right - left);
                res = Math.Max(area, res);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }

            }
            return res;
        }
    }
}
