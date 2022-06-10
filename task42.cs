using System;
using System.Collections.Generic;

public class Solution
{
    
    public static void Main()
    {
        string str = Console.ReadLine();
        List<int> l = new List<int>();
        string substr = Console.ReadLine();
        int c = 0;
        for (int i = 0; i < str.Length - substr.Length + 1; i++)
        {
            c = 0;
            for (int j = 0; j < substr.Length; j++)
            {
                if (str[i + j] == substr[j] || substr[j] == '?')
                {
                    c++;
                }
            }

            if (substr.Length == c)
            {
                l.Add(i + 1);
            }
        }
        Console.WriteLine(String.Join(" ", l));
    }
}