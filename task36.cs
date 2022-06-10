using System;
using System.Collections.Generic;

public class Solution
{
    static bool NeobSl(string s)
    {
        bool fl = true;int k = 0;
        for (int i = 0; i < s.Length; i++) {
            if (k >= 3) return fl;
            if (s[i] == 'e' || s[i] == 'o' || s[i] == 'y' || s[i] == 'u' || s[i] == 'a' || s[i] == 'i')
                k++;
            else k = 0; }
            

        return false;
    }
    public static void Main()
    {        
        int n = Int32.Parse(Console.ReadLine());
        var list = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            if (NeobSl(s)) continue;
            else list.Add(s);
        }
        foreach (var s in list)
            Console.WriteLine(s);
    }
}