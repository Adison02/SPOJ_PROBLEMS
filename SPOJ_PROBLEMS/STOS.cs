/// <summary>
/// STOS - Stos
/// </summary>
public static class STOS
{
    public static void Run()
    {
        Stack stack = new Stack();

        string input;
        while ((input = Console.ReadLine()) != null)
        {
            if (input == "-")
            {
                int val = stack.Pop();
                Console.WriteLine(val != -1 ? val.ToString() : ":(");
            } else if (input == "+")
            {
                int n;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    string result = stack.Push(n);
                    Console.WriteLine(result);
                } else
                {
                    Console.WriteLine(":(");
                }
            }
        }
    }

    internal class Stack
    {
        int Top = -1;
        int[] StackArray = new int[10];

        public string Push(int n)
        {
            if (Top < StackArray.Length - 1)
            {
                Top++;
                StackArray[Top] = n;
                return ":)";
            } else
            {
                return ":(";
            }
        }

        public int Pop()
        {
            if (Top == -1)
            {
                return -1;
            } else
            {
                int val = StackArray[Top];
                Top--;
                return val;
            }
        }
    }
}