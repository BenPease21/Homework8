public class RecentCounter
{
    private List<int> requests;
    private int startIndex;

    public RecentCounter()
    {
        requests = new List<int>();
        startIndex = 0;
    }

    public int Ping(int t)
    {
        requests.Add(t);

        while (requests[startIndex] < t - 3000)
        {
            startIndex++;
        }

        return requests.Count - startIndex;
    }
}
