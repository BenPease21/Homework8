using System.Collections.Generic;


// Idk why this one isn't working in Visual Studio,
// it runs in the code, but its erroring out like crazy here


class Solution
{
    public:
    bool isValid(string s)
    {
        stack<char> stack;
        unordered_map<char, char> bracketMap = {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        for (char c : s)
        {
            if (bracketMap.count(c))
            {
                if (stack.empty() || stack.top() != bracketMap[c])
                {
                    return false;
                }
                stack.pop();
            }
            else
            {
                stack.push(c);
            }
        }

        return stack.empty();
    }
};