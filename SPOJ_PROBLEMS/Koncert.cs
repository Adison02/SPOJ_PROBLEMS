/// <summary>
/// WSEIHACK2004A - Koncert(Code golf) (684 znaki)
/// </summary>
public static class Koncert
{
    public static void Run()
    {
        var t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            var input = Console.ReadLine().Split(',');
            var sum = 0;
            for (int i = 0; i < input.Count(); i++)
            {
                var time = input[i].Split(':');
                var minutes = int.Parse(time[0]);
                var seconds = int.Parse(time[1]);
                sum += minutes * 60 + seconds;
            }
            var result = (int)Math.Ceiling((double)sum / input.Count());
            Console.Write(input.Count() + " " + format(result) + " " + format(sum) + "\n");
        }

        string format(int sum)
        {
            var hour = sum / 3600;
            if (hour == 0)
                return $"{(sum / 60) % 60}:{sum % 60:00}";
            else
                return $"{hour}:{(sum / 60) % 60:00}:{sum % 60:00}";
        }
    }
}