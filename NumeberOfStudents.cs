﻿class Solution
{
    public:
    int countStudents(vector<int>& students, vector<int>& sandwiches)
    {
        queue<int> q;
        for (int s : students)
        {
            q.push(s);
        }

        int i = 0; 
        int failedAttempts = 0;

        while (!q.empty() && failedAttempts < q.size())
        {
            if (q.front() == sandwiches[i])
            {
                q.pop();
                i++;
                failedAttempts = 0; 
            }
            else
            {
                q.push(q.front());
                q.pop();
                failedAttempts++;
            }
        }

        return q.size(); 
    }
};
