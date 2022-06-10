using System;
using System.Collections.Generic;

public class Solution
{
    
    public static void Main()
    {
        string s = Console.ReadLine();
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= 'A' && s[i] <= 'Z')
            {
                res += s[i];
            }
            else if (s[i] == ' ')
            {
                if (s[i - 1] != ' ' && res[res.Length - 1] != ' ')
                {
                    res += ' ';
                }

            }
            else if (s[i] == ',' || s[i] == '.' || s[i] == '!' || s[i] == '?')
            {
                if (s[i - 1] == ' ')
                {
                    res = res.Remove(res.Length - 1);
                }
                res += s[i] + " ";
            }
        }
        Console.WriteLine(res);
    }
}