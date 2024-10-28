using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public static class MaximumAreaInHistogram
    {

        public static void main() {
            
            int[] arr = new int []{ 1 };

            Console.WriteLine( LargestRectangleArea(arr));

        }


        public static int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            Stack<KeyValuePair<int, int>> nsl = new Stack<KeyValuePair<int, int>>();
            int[] nslArr = new int[heights.Length];

            Stack<KeyValuePair<int, int>> nsr = new Stack<KeyValuePair<int, int>>();
            int[] nsrArr = new int[heights.Length];
            // Find Neatest Smaller to right
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                if (nsr.Count == 0)
                {
                    nsrArr[i] = heights.Length;
                }
                else if (nsr.Peek().Value < heights[i])
                {
                    nsrArr[i] = nsr.Peek().Key;
                }
                else if (nsr.Peek().Value >= heights[i]) {

                    while (nsr.Count != 0 && nsr.Peek().Value >= heights[i]) {
                        nsr.Pop();
                    }

                    if (nsr.Count == 0)
                    {
                        nsrArr[i] = heights.Length;
                    }
                    else {
                        nsrArr[i] = nsr.Peek().Key;
                    }
                }
                nsr.Push(new KeyValuePair<int, int>(i,heights[i]));
            }





            //Find Nearest smaller to left
            for (int i = 0; i < heights.Length; i++)
            {
                if (nsl.Count == 0)
                {
                    nslArr[i] = -1;
                }
                else if (nsl.Peek().Value < heights[i])
                {
                    nslArr[i] = nsl.Peek().Key;
                }
                else if (nsl.Peek().Value >= heights[i])
                {

                    while (nsl.Count != 0 && nsl.Peek().Value >= heights[i])
                    {
                        nsl.Pop();
                    }

                    if (nsl.Count == 0)
                    {
                        nslArr[i] = -1;
                    }
                    else
                    {
                        nslArr[i] = nsl.Peek().Key;
                    }
                }
                nsl.Push(new KeyValuePair<int, int>(i, heights[i]));
            }


            // calculate the width

            int[] width = new int[heights.Length];


            for (int i = 0; i < heights.Length; i++) {

                width[i] = nsrArr[i] - nslArr[i] - 1;
            }



            // calculate the area
            int[] area = new int[heights.Length];
            for (int i = 0; i < heights.Length; i++)
            {
                area[i] = width[i] * heights[i];
                maxArea = Math.Max(area[i],maxArea);
            }



            // find the max area


            // return max area;

            return maxArea;
        }

    }
}
