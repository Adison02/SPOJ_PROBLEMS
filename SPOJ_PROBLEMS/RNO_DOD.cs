using System.Text;

/// <summary>
/// RNO_DOD - Proste dodawanie
/// </summary>
public static class RNO_DOD
{
    public static void Run()
    {
        var t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            var n = int.Parse(Console.ReadLine());

            int sum = 0;
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Clear();
                while (true)
                {
                    int nextChar = Console.Read();
                    if (nextChar == ' ' || nextChar == '\n' || nextChar == -1)
                        break;
                    sb.Append((char)nextChar);
                }
                sum += int.Parse(sb.ToString());
            }
            Console.WriteLine(sum);
        }
    }

    public static void Run2()
    {
        var t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split();

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(input[i]);
            }
            Console.WriteLine(sum);
        }
    }
}