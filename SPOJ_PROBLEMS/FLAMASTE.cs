/// <summary>
/// 
/// </summary>
public static class FLAMASTE
{
    public static void Run()
    {
        var C = int.Parse(Console.ReadLine());
        for (int c = 0; c < C; c++)
        {
            string tekst = Console.ReadLine();
            string wynik = "";
            int ile = 1, j = 0;
            while (j < tekst.Length)
            {
                ile = 1;
                char aktualnyZnak = tekst[j];
                j++;
                for (; j < tekst.Length && tekst[j] == aktualnyZnak; j++)
                {
                    ile++;
                }
                if (ile == 1)
                {
                    wynik += aktualnyZnak.ToString();
                } else if (ile == 2)
                {
                    wynik += aktualnyZnak.ToString();
                    wynik += aktualnyZnak.ToString();
                } else
                {
                    wynik += aktualnyZnak.ToString() + ile.ToString();
                }
            }
            Console.WriteLine(wynik);
        }
    }
}