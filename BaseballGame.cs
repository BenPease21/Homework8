public class Solution
{
    public int CalPoints(IList<string> operations)
    {
        List<int> record = new List<int>();

        foreach (string op in operations)
        {
            if (op == "C")
            {
                record.RemoveAt(record.Count - 1);
            }
            else if (op == "D")
            {
                record.Add(2 * record[record.Count - 1]);
            }
            else if (op == "+")
            {
                int n = record.Count;
                record.Add(record[n - 1] + record[n - 2]);
            }
            else
            {
                record.Add(int.Parse(op));
            }
        }

        int total = 0;
        foreach (int score in record)
        {
            total += score;
        }

        return total;
    }
}
