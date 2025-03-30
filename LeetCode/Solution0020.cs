namespace LeetCode;
public class Solution0020
{
    private Dictionary<char, char> _dictionary;

    public bool IsValid(string s)
    {
        _dictionary = new Dictionary<char, char>();
        _dictionary.Add('(', ')');
        _dictionary.Add('[', ']');
        _dictionary.Add('{', '}');
        Stack<char> stack = new Stack<char>();
        var response = Helper(0, s, stack);
        return response && stack.Count == 0;
    }

    private bool Helper(int i, string s, Stack<char> stack)
    {
        if (i < s.Length)
        {
            if (stack.Count == 0 || _dictionary[stack.Peek()] != s[i])
            {
                if (_dictionary.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                    return Helper(i + 1, s, stack);
                }
                return false;
            
            }
            else
            {
                stack.Pop();
                return Helper(i + 1, s, stack);
            }
        }
        return true;
    }
}