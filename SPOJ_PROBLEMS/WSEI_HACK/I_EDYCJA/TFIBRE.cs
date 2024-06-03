/// <summary>
/// TFIBRE - Sieć czysto światłowodowa
/// </summary>
public static class TFIBRE
{
    public static void Run()
    {
        var fibre = new Fibre();

        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] parts = line.Split(" ");
            string type = parts[0];
            string addressA = parts[1];
            string addressB = parts[2];

            if (type == "B")
            {
                fibre.BuildConnection(addressA, addressB);
            } else if (type == "T")
            {
                Console.WriteLine(fibre.CheckConnection(addressA, addressB) ? "T" : "N");
            }
        }
    }

    public class Fibre
    {
        private Dictionary<string, List<string>> connections;
        private HashSet<string> visited;

        public Fibre()
        {
            connections = new Dictionary<string, List<string>>();
            visited = new HashSet<string>();
        }

        public void BuildConnection(string addressA, string addressB)
        {
            if (!connections.ContainsKey(addressA))
            {
                connections[addressA] = new List<string>();
            }
            if (!connections.ContainsKey(addressB))
            {
                connections[addressB] = new List<string>();
            }

            connections[addressA].Add(addressB);
            connections[addressB].Add(addressA);
        }

        public bool CheckConnection(string start, string target)
        {
            visited.Clear();
            return DFS(start, target);
        }

        private bool DFS(string current, string target)
        {
            if (current == target)
            {
                return true;
            }

            visited.Add(current);

            foreach (string neighbor in connections[current])
            {
                if (!visited.Contains(neighbor))
                {
                    if (DFS(neighbor, target))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}