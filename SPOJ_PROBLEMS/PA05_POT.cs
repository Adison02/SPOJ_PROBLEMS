/// <summary>
/// PA05_POT - Czy umiesz potęgować
/// </summary>
public class PA05_POT
{
    public static void Run()
    {
        int D = int.Parse(Console.ReadLine());

        for (int i = 0; i < D; i++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int result = LastDigitOfPower(a, b);
            Console.WriteLine(result);
        }

        int LastDigitOfPower(int a, int b)
        {
            if (b == 0)
                return 1;

            int[] cycle = calcCycle(a);

            int cycleIndex = (b % 4 == 0) ? 3 : (b % 4) - 1;

            return cycle[cycleIndex];
        }

        int[] calcCycle(int a)
        {
            int lastDigitOfA = a % 10;
            int lastDigitOfPower = 1;
            int[] result = new int[4];

            for (int i = 0; i < 4; i++)
            {
                lastDigitOfPower = (lastDigitOfPower * lastDigitOfA) % 10;
                result[i] = lastDigitOfPower;
            }

            return result;
        }
    }
}