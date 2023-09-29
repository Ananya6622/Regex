using System;
using System.Text.RegularExpressions;

public class HTMLTag
{
    public static void Main()
    {
        string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
        string pattern = "<[^>]+>";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
