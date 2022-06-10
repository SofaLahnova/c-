using System;
using System.Collections.Generic;

public class Solution
{
    
    public static void Main()
    {
        int k = 0;
        string s = Console.ReadLine();
        for (int i = 0; i < s.Length - 1; i++) { 
            if (((s[i] >= 65 && s[i] <= 90) || (s[i] >= 97 && s[i] <= 122)) && !((s[i + 1] >= 65 && s[i + 1] <= 90) || (s[i + 1] >= 97 && s[i + 1] <= 122)))
                k++;
        }
        var r = s[s.Length - 1];
        if ((r >= 65 && r <= 90) || (r >= 97 && r <= 122)) k++;
        
            Console.WriteLine(k);
    }
}