using System;
using System.Text.RegularExpressions;

public class StringMatch
{
    public static void Main()
    {
        string input = "ab abb abbb abbbb";
        string pattern = "ab{2,3}";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
