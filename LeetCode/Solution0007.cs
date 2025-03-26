namespace LeetCode;

public class Solution0007
{
    public static int Reverse(int x)
    {
        int result = 0;
        while (x != 0)
        {
            int remainder = x % 10;
            if (result > int.MaxValue/10)
                return 0;
            if (result < int.MinValue / 10)
                return 0;
            result = result * 10 + remainder;
            x /= 10;
        }
        return result;
    }
}