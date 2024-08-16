using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Two_Pointer
{
    public partial class TwoPointer
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var resultSet = new HashSet<int []>();
            Array.Sort(nums);
            int i = 0;
            for (i =0; i < nums.Length - 2;i++) {
                int j = i+1;
                int k = nums.Length - 1;


                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                while ( j < k )
                {
                    if ((nums[i] + nums[j] + nums[k]) > 0)
                    {
                        k--;
                    }
                    else if ((nums[i] + nums[j] + nums[k]) < 0)
                    {
                        j++;
                    }
                    else if ((nums[i] + nums[j] + nums[k]) == 0) {
                        resultSet.Add(new int [] {nums[i], nums[j], nums[k]});
                        j++;
                        while (j < k && nums[j] == nums[j + 1] ) {
                            j++;
                        }
                    }
                    
                }
                
            }
            return (IList<IList<int>>)resultSet.ToArray();
        }
    }
}
