using System;

    public class Solution
    {
        static void Main(string[] args)
        {
        int a, b, n = 0;
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        a = arr[0];
        b = arr[1];
        //if (a < b)
        //    (a, b) = (b, a);

        while (a != 0 && b != 0)
        {
            if (a > b) a -= b;
            else b -= a;
            //(a, b) = (b, a);
            n += 1;
        }
        int res = a + b;
        Console.WriteLine(n + " " + res);
    }
    }
