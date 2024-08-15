using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Two_Pointer
{
    public partial class TwoPointer
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            //Given a 1 - indexed array of integers numbers that is already sorted in non - decreasing order,
            //find two numbers such that they add up to a specific target number.Let these two numbers be
            //numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.
            int[] indexArr = new int[2];
            int curr = 0;
            int next = numbers.Length - 1;
            int currSum = (numbers[curr] + numbers[next]);
            while (currSum != target) {
                if (currSum > target)
                {
                    next--;
                }
                else {
                    curr++;
                }
                currSum = (numbers[curr] + numbers[next]);
            }
            indexArr[0] = curr + 1;
            indexArr[1] = next + 1;
            return indexArr;
        }
    }
}
