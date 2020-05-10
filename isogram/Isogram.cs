using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string subString = "";

        word = word.ToLower().Replace("-", "").Replace(" ", "");
        foreach (char ch in word)
            if (!subString.Contains(ch))
               subString += ch;
            else 
                return false;
        return true;
    }
}
