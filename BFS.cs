namespace algorithms;

public class BFS
{
    public static void run(string[] airports, string[][] routes, string from, string to)
    {
        var adjacentList = new Dictionary<string, List<string>>();

        foreach(var route in routes)
        {
            var _from = route[0];
            var _to = route[1];

            if (!adjacentList.ContainsKey(_from))
            {
                adjacentList[_from] = new List<string>();
            }

            adjacentList[_from].Add(_to);

            if(!adjacentList.ContainsKey(_to))
            {
                adjacentList[_to] = new List<string>();
            }

            adjacentList[_to].Add(_from);
        }

        if( bfs(from, to, adjacentList) )
        {
            Console.WriteLine($"found route from {from} to {to}");
        }
    }

    private static bool bfs(string from, string to, Dictionary<string, List<string>> adjacentList)
    {
        var queue = new Queue<string>();
        queue.Enqueue(from);

        while(queue.Count > 0)
        {
            showQueue(queue);

            var fromAirport = queue.Dequeue();
            Console.WriteLine($"visiting {fromAirport}...");

            foreach(var airport in adjacentList[fromAirport])
            {
                if(!queue.Contains(airport))
                    queue.Enqueue(airport);

                if(fromAirport == to)
                {
                    Console.WriteLine($"connection found between {from} to {to}.");
                    return true;
                }
            }
        }

        return false;
    }

    private static void showQueue(Queue<string> queue)
    {
        var q = new Queue<string>(queue);
        while(q.Count > 0)
        {
            var node = q.Dequeue();
            Console.Write(node + "|");
        }
        Console.WriteLine("x");
    }
}