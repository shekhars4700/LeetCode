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
            bool result = false;
            int newFlowerCount = 0;
            if (n == 0) {
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
                if (flowerbed.Contains(1))
                {
                    return false;
                }
            }
            for (int i = 1; i < flowerbed.Length -1; i++)
            {
                if (i == 1 && flowerbed[i - 1] == 0 && flowerbed[i] ==0) {
                    flowerbed[i - 1] = 1;
                    newFlowerCount++;
                }
                else if (flowerbed[i - 1] == 0 && flowerbed[i] != 1 && flowerbed[i + 1] == 0) {
                    flowerbed[i] = 1;
                    newFlowerCount++;
                }
                else if (i+1 == flowerbed.Length -1  && flowerbed[i] == 0 && flowerbed[i +1] == 0) {
                    flowerbed[i] = 1;
                    newFlowerCount++;
                }
            }
            return newFlowerCount <= n ? true:false;
        }
    }
}
