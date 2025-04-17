public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        Queue<int> q = new Queue<int>();
        foreach (int s in students)
        {
            q.Enqueue(s);
        }

        int i = 0;
        int failedAttempts = 0;

        while (q.Count > 0 && failedAttempts < q.Count)
        {
            if (q.Peek() == sandwiches[i])
            {
                q.Dequeue();
                i++;
                failedAttempts = 0;
            }
            else
            {
                q.Enqueue(q.Dequeue());
                failedAttempts++;
            }
        }

        return q.Count;
    }
}
