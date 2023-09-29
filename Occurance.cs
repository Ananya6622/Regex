using System;
using System.Text.RegularExpressions;

public class Occurance
{
    public static void Main()
    {
        string pattern = "fox(es)?";
        string input = "foxes are omnivorous mammals belonging to several genera of the family Canidae fox.";

        int count = Regex.Matches(input, pattern).Count;

        Console.WriteLine("There are " + count + " occurrences.");
    }
}
