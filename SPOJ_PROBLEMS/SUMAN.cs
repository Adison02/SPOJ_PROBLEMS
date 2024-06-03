/// <summary>
/// SUMAN - Suma
/// </summary>
public static class SUMAN
{
    public static void Run()
    {
        for (int i = 0; i < 10; i++)
        {
            int n = int.Parse(Console.ReadLine()) + 1;
            int sum = 0;
            while (n-- > 0)
            {
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}