using System.Linq;

public class StripCommentsSolution
{
    public static void Main()
    {
        // Test
        var t = StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new[] { "#", "!" });
        // ...should return "apples, pears\ngrapes\nbananas"
    }

    public static string StripComments(string text, string[] commentSymbols)
    { 
        string[] lines = text.Split("\n").Select(str => str.Split(commentSymbols, 0).First().TrimEnd()).ToArray();

        return string.Join("\n", lines);
    }
}