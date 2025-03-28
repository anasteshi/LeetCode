using System.Text;

namespace LeetCode;

public class Solution0043
{
    public static string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0") return "0";
        int m = num1.Length;
        int n = num2.Length;
        int[] result = new int[m+n];
        for (int i = m-1; i >= 0; i--)
        {
            for (int j = n-1; j >= 0; j--)
            {
                int product = (num1[i]-'0') * (num2[j]-'0');
                int temp = result[i+j+1] + product;
                
                result[i+j+1] = temp % 10;
                result[i+j] += temp / 10;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (var num in result)
        {
            if (!(sb.Length == 0 && num == 0))
                sb.Append(num);
        }
        return sb.ToString();
    }
}