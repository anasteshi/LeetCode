namespace LeetCode;

public class Solution0014
{
    public static string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            string currentPrefix = string.Empty;
            for (int j = 0; j < strs[i].Length; j++)
            {
                if (j >= prefix.Length) 
                    break;
                if (strs[i][j] == prefix[j]) 
                    currentPrefix += strs[i][j];
                else
                    break;
            }
            prefix = currentPrefix;
        }
        return prefix;
    }

    public static string LongestCommonPrefix2(string[] strs)
    {
        if (strs.Length > 1)
        {
            Array.Sort(strs);
            string first = strs[0];
            string last = strs[^1];
            string prefix = string.Empty;
            for (int i = 0; i < Math.Min(first.Length, last.Length); i++)
            {
                if (first[i] != last[i]) return prefix;
                prefix += first[i];
            }

            return prefix;
        }
        else if (strs.Length == 1) return strs[0];
        else return null;
    }
}