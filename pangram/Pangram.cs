using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        input = input.ToLower();
        for(int i = 0; i < alphabets.Length; i++)
        {
            if(!input.Contains(alphabets[i].ToString()))
                return false;
        }
        return true;
    }
}
