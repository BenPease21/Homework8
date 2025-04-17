using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> bracketMap = new Dictionary<char, char>
        {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach (char c in s)
        {
            if (bracketMap.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Peek() != bracketMap[c])
                {
                    return false;
                }
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
