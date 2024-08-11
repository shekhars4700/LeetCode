using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int newFlowerCount = 0;
            if (n == 0)
            {
                return true;
            }
            else if (flowerbed.Length == 1)
            {
                if (flowerbed.Contains(0))
                {
                    return true;
                }

            }
            else if (flowerbed.Length == 2)
            {
                if (!flowerbed.Contains(1))
                {
                    newFlowerCount++;
                }
            }
            else
            {
                for (int i = 0; i < flowerbed.Length; i++)
                {
                    if (flowerbed[i] == 0)
                    {
                        int prev = i == 0 ? 0 : flowerbed[i - 1];
                        int next = i == flowerbed.Length - 1 ? 0 : flowerbed[i + 1];

                        if (prev == 0 && next == 0)
                        {
                            flowerbed[i] = 1;
                            newFlowerCount++;
                        }
                    }
                }
            }
            return n <= newFlowerCount ? true : false;
        }
    }
}
