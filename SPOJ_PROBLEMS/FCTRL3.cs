/// <summary>
/// FCTRL3 - Dwie cyfry silni
/// </summary
public static class FCTRL3
{
    public static void Run()
    {
        var D = int.Parse(Console.ReadLine());
        for (int i = 0; i < D; i++)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fractionMod100(n));
        }

        string fractionMod100(int n)
        {
            if (n > 9) return "0 0";

            int factorial = 1;
            for (int j = 2; j <= n; j++)
            {
                factorial *= j;
            }
            string r = (factorial % 100).ToString();
            if (r.Length == 1) r = $"0{r}";
            return $"{r[0]} {r[1]}";
        }
    }
}