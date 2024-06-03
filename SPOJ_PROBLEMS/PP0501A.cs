/// <summary>
/// PP0501A - NWD
/// </summary>
public static class PP0501A
{
    public static void Run()
    {
        var t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            var input = Console.ReadLine().Split();
            var a = int.Parse(input[0]);
            var b = int.Parse(input[1]);

            Console.WriteLine(NWD(a, b));
        }


        int NWD(int a, int b)
        {
            if (b == 0)
                return a;
            return NWD(b, a % b);
        }
    }

    public static void Run2()
    {
        var t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            var input = Console.ReadLine().Split();
            var a = int.Parse(input[0]);
            var b = int.Parse(input[1]);

            Console.WriteLine(NWD(a, b));
        }

        int NWD(int a, int b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }
            return a;
        }
    }
}