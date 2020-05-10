using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] separators = { ' ', '-', '_' };
        var words = phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string abberviation = "";
        foreach (var word in words)
        {
            abberviation += word[0].ToString().ToUpper();
        }
        return abberviation;
    }
}
