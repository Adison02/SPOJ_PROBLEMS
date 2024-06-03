/// <summary>
/// PP0601B - Podzielność
/// </summary>
public static class PP0601B
{
    public static void Run()
    {
        var t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            var input = Console.ReadLine().Split();
            var n = int.Parse(input[0]);
            var x = int.Parse(input[1]);
            var y = int.Parse(input[2]);

            for (int ai = 2; ai < n; ai++)
            {
                if (ai % x == 0 && ai % y != 0)
                {
                    Console.Write(ai + " ");
                }
            }
            Console.WriteLine();
        }
    }
}