using System;
using System.Text.RegularExpressions;

public class LowerCase
{
    public static void Main()
    {
        string input = "hello_world abc_xyz123 test_var";
        string pattern = "[a-z]+_[a-z]+";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
