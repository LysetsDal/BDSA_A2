namespace Assignment2;

using System.Text.RegularExpressions;


public static class Extensions
{
    public static bool IsSecure(this Uri uri)
    {
        return uri.Scheme == Uri.UriSchemeHttps;
    }

    public static int WordCount(this string word) {
        //only unicode letters (no numbers or symbols)
        /*var input = word.Split(" ");
        
        return input.Length;*/

        MatchCollection col = Regex.Matches(word, @"[\S]+");
        return col.Count;
    }

}
