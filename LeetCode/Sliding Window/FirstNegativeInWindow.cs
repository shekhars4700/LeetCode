using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sliding_Window
{
    public partial class SlidingWindow
    {
        public List<long> printFirstNegativeInteger(long[] A, long N, long K)
        {
            int i = 0;
            int j = 0;
            List<long> numArr = new List<long>();
            List<long> numReturnArr = new List<long>();

            while (j < N)
            {
                if (A[j] < 0)
                {
                    numArr.Add(A[j]);
                }
                if ((j - i + 1) != K)
                {
                    j++;
                }
                else if ((j - i + 1) == K)
                {
                    if (numArr.Count == 0)
                    {
                        numReturnArr.Add(0);
                    }
                    else
                    {
                        numReturnArr.Add(numArr[0]);
                        numArr = new List<long>();
                    }
                    i++;
                }
            }
            return numReturnArr;
        }
    }
}
