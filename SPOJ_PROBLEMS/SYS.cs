using System.Text;

/// <summary>
/// SYS - Systemy pozycyjne
/// </summary>
public static class SYS
{
    public static void Run()
    {
        var t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(ConvertToBase(n, 16));
            Console.Write(" ");
            Console.Write(ConvertToBase(n, 11));
            Console.WriteLine();
        }

        string ConvertToBase(int n, int p)
        {
            var result = new StringBuilder();

            while (n > 0)
            {
                int remainder = n % p;
                char digit = (remainder < 10) ? (char)(remainder + '0') : (char)(remainder - 10 + 'A');
                result.Insert(0, digit);
                n /= p;
            }

            return result.ToString();
        }
    }
}