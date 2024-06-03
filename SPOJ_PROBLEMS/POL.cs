using System.Text;

/// <summary>
/// POL - Połowa
/// </summary>
public static class POL
{
    public static void Run()
    {
        var t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            var input = Console.ReadLine();
            Console.WriteLine(input.Substring(0, input.Length / 2));
        }
    }

    public static void Run2()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            string input = Console.ReadLine();
            int middleIndex = input.Length / 2;

            StringBuilder firstHalf = new StringBuilder(input.Length / 2);
            firstHalf.Append(input.Substring(0, middleIndex));

            Console.WriteLine(firstHalf);
        }
    }
}