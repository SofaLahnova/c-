using System;
using System.Collections.Generic;

public class Solution
{
    static bool Polyndrom(string str, int n)
        {
            int c = 0;
            for (int i = 0; i<n / 2; i++)
            {
                if (str[i] == str[n - i - 1])
                {
                    c++;
                }
            }
            return (c == n / 2);
            
        }

        static void Main(string[] args)
{
    string str = Console.ReadLine();
    int n = str.Length;

    if (Polyndrom(str, n))
    {
        Console.WriteLine("YES");
    }
    else
    {
        string res = "";
        int c = 0;
        for (int i = 0; i < n; i++)
        {
            res += str[i];
            if (Polyndrom(res, res.Length) && res.Length > 1)
            {
                c++;
                res = "";
            }
            // Console.WriteLine(res);
            if (i == n - 1 && res == Convert.ToString(str[n - 1])) c++;
        }
        if (c == 2)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");

        }
    }
}
}