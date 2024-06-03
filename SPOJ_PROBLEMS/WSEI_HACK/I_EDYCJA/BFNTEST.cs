using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// BFNTEST - Precz z komentarzami!
/// </summary>
public static class BFNTEST
{
    public static void Run()
    {
        var code = new List<string>();
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            code.Add(line);
        }

        if(code.Count > 0)
        {
            var codeWithoutComments = RemoveCommentsRegex(string.Join("\n", code));

            Console.WriteLine(codeWithoutComments);
        }
    }

    public static void Run2()
    {
        string filePath = "Resources/BFNTEST.txt";

        var code = File.ReadAllText(filePath);

        var codeWithoutComments = RemoveCommentsRegex(code);

        Console.WriteLine(codeWithoutComments);
    }

    //1 test
    static string RemoveComments(string code)
    {
        StringBuilder result = new StringBuilder();
        bool inSingleLineComment = false;
        bool inMultiLineComment = false;
        bool inB = false;

        for (int i = 0; i < code.Length; i++)
        {
            if (!inSingleLineComment && !inMultiLineComment && !inB && code[i] == '"')
            {
                result.Append(code[i]);
                inB = true;
            } else if (!inSingleLineComment && !inMultiLineComment && inB && code[i] == '"')
            {
                result.Append(code[i]);
                inB = false;
            } else if (!inSingleLineComment && !inMultiLineComment && !inB && code[i] == '/')
            {
                if (i + 1 < code.Length && code[i + 1] == '/')
                {
                    inSingleLineComment = true;
                    i++;
                } else if (i + 1 < code.Length && code[i + 1] == '*')
                {
                    inMultiLineComment = true;
                    i++;
                } else
                {
                    result.Append(code[i]);
                }
            } else if (inSingleLineComment && code[i] == '\n')
            {
                inSingleLineComment = false;
            } else if (inMultiLineComment && code[i] == '*')
            {
                if (i + 1 < code.Length && code[i + 1] == '/')
                {
                    inMultiLineComment = false;
                    i++;
                }
            } else if (!inSingleLineComment && !inMultiLineComment)
            {
                result.Append(code[i]);
            }
        }

        return result.ToString();
    }

    //6 testow
    static string RemoveCommentsRegex(string code)
    {
        // Wzorzec do usuwania komentarzy
        string pattern = @"\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+\/|//.*?$";

        // Usunięcie komentarzy z kodu za pomocą wyrażenia regularnego
        return Regex.Replace(code, pattern, "", RegexOptions.Multiline);
    }
}