using System;

namespace GazpromTest
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if(nums.Length == 4)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[2] { i, j };
                        }
                    }
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
