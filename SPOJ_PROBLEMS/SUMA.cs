/// <summary>
/// SUMA - Suma
/// </summary>
public static class SUMA
{
    public static void Run()
    {
        int sum = 0;
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int number = int.Parse(line);
            sum += number;
            Console.WriteLine(sum);
        }
    }
}