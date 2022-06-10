using System;

    public class Solution
    {
        static void Main(string[] args)
        {
        int a = Int32.Parse(Console.ReadLine());
        int f, d;
        f = a / 36;
        a = a- f*36;
        d = (int)Math.Round(a/3.0);

        Console.WriteLine(f+" "+ d);
        }
    }
