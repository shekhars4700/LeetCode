using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public static class RainWaterTrapping
    {
        public static int Trap(int[] heights)
        {
            int[] minArray = new int[heights.Length];

            int[] GreaterToRight = new int[heights.Length];
            GreaterToRight[heights.Length - 1] = heights[heights.Length - 1];

            int[] GreaterToLeft = new int[heights.Length];
            GreaterToLeft[0] = heights[0];

            // Find Neatest Greater to Right
            for (int i = heights.Length - 2; i >= 0; i--)
            {
                GreaterToRight[i] = Math.Max(GreaterToRight[i + 1], heights[i]);
            }

            //Find Nearest Greater to left
            for (int i =1; i < heights.Length; i++)
            {
                GreaterToLeft[i] = Math.Max(GreaterToLeft[i - 1], heights[i]);
            }

            // Find the minArray
            for (int i = 0; i < heights.Length; i++)
            {
                minArray[i] = Math.Min(GreaterToLeft[i], GreaterToRight[i]);
            }


            int result = 0;
            int[] newArray = new int[heights.Length];
            for (int i = 0; i < heights.Length; i++)
            {
                newArray[i] = minArray[i] - heights[i];
                result += newArray[i];
            }
            return result;
        }
    }
}
