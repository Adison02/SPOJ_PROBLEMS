/// <summary>
/// STPAR - Street Parade
/// </summary>
public static class STPAR
{
    public static void Run()
    {
        int n = int.Parse(Console.ReadLine());
        do
        {
            int[] mobiles = Console.ReadLine().Split().Select(mobile => int.Parse(mobile)).ToArray<int>();

            Stack<int> stack = new Stack<int>();
            int need = 1;
            bool poss = true;

            for (int i = 0; i < n; i++)
            {
                while (stack.Any() && stack.Peek() == need)
                {
                    need++;
                    stack.Pop();
                }

                if (mobiles[i] == need)
                {
                    need++;
                } else if (stack.Any() && stack.Peek() < mobiles[i])
                {
                    poss = false;
                    break;
                } else
                {
                    stack.Push(mobiles[i]);
                }

            }

            Console.WriteLine(poss ? "yes" : "no");
            n = int.Parse(Console.ReadLine());
        }
        while (n != 0);
    }
}