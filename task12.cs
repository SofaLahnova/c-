using System;

    public class Solution
    {
        static void Main(string[] args)
        {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int fl = 0;int r;
        if (a[0] == b[0])
            if (a[1] + b[1] == a[0]) fl=1;
            else r=0;
        if (a[0] == b[1])
            if (a[1] + b[0] == a[0]) fl=1;
            else r=0;
        if (a[1] == b[0])
            if (a[0] + b[1] == a[1]) fl=1;
            else r=0;
        if (a[1] == b[1])
            if (a[0] + b[0] == a[1]) fl=1;
            else r=0;
        if (fl == 1) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
    }
