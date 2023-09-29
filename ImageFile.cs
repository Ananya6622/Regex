using System;
using System.Text.RegularExpressions;

public class ImageFile
{
    public static void Main()
    {
        string input = "image1.jpg file2.png document.txt image3.jpeg";
        string pattern = @"\w+\.(jpg|png|jpeg|gif|bmp)";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
