using System;

public class Solution
{
    public long CountSubstrings(string s, char c)
    {
        long count = 0;

        foreach (char ch in s)
        {
            if (ch == c)
                count++;
        }

        return count * (count + 1) / 2;
    }

   
}
