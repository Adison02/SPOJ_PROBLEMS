/// <summary>
/// PRIME_T - Liczby Pierwsze
/// </summary>
public static class PRIME_T
{
    public static void Run()
    {
        var z = int.Parse(Console.ReadLine());
        for (int i = 0; i < z; i++)
        {
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(a));
        }
        string IsPrime(int a)
        {
            if (a == 2) return "TAK";
            if (a <= 1 || a % 2 == 0) return "NIE";

            int sqrt = (int)Math.Sqrt(a);
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (a % i == 0)
                    return "NIE";
            }

            return "TAK";
        }
    }
}