namespace LeetCode;

public class Solution0001
{
    public int[] nums;
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i <= nums.Length - 2; i++)
        {
            for (int j = i + 1; j <= nums.Length - 1; j++)
            {
                int currentSum;
                currentSum = nums[i] + nums[j];
                if (currentSum == target)
                    return new int[] { i, j };
            }
        }
        return null;
    }
}