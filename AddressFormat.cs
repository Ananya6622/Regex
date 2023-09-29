using System;
using System.Text.RegularExpressions;

public class AddressFormat
{
    public static void Main()
    {
        string input = "https://www.example.com https://invalid.url http://valid-url.com";
        string pattern = @"^https?://([a-zA-Z0-9.-]+)\.([a-zA-Z]{2,6})(:[0-9]{1,5})?(/.*)?$";

        foreach (Match match in Regex.Matches(input, pattern))
        {
            Console.WriteLine(match.Value);
        }
    }
}
