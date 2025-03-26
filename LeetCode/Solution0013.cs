namespace LeetCode;

public class Solution0013
{
    public static int RomanToInt(string s)
    {
        string[] roman = {"I", "V", "X", "L", "C", "D", "M"};
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            string currentCharacter = s[i].ToString();
            string nextCharacter = NextCharacter(s, i);
            
            if (currentCharacter == "I")
            {
                if (nextCharacter == "V")
                {
                    result += 4;
                    i++;
                }
                else if (nextCharacter == "X")
                {
                    result += 9;
                    i++;
                }
                else result += 1;
            }
            
            else if (currentCharacter == "V")
                result += 5;
            
            else if (currentCharacter == "X")
            {
                if (nextCharacter == "L")
                {
                    result += 40;
                    i++;
                }
                else if (nextCharacter == "C")
                {
                    result += 90;
                    i++;

                }
                else result += 10;
            }
            
            else if (currentCharacter == "L")
                result += 50;
            
            else if (currentCharacter == "C")
            {
                if (nextCharacter == "D")
                {
                    result += 400;
                    i++;

                }
                else if (nextCharacter == "M")
                {
                    result += 900;
                    i++;
                }
                else result += 100;
            }
            
            else if (currentCharacter == "D")
                result += 500;
            
            else result += 1000;
        }
        return result;
    }

    static string NextCharacter(string s, int index)
    {
        index++;
        if (index >= s.Length)
            return string.Empty;
        return s[index].ToString();
    }
}