using System;
using System.Collections.Generic;

public class Solution
{
    public static int Del(int n)
    {
        int c = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) c++;
        return c;

    }
    public static void Main()
    {
        int a, b, n, maxElem = 0;
        var dividers = new Dictionary<int, int>();
        List<int> numbers = new List<int>();
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        a = arr[0];
        b = arr[1];

        for (int num = a; num <= b; num++)
        {
            dividers[num] = Del(num);
        }

        for (int num = a; num <= b; num++)
        {
            if (dividers[num] > maxElem)
                maxElem = dividers[num];
        }
        n = 0;
        for (int num = a; num <= b; num++)
        {
            if (dividers[num] == maxElem)
            {
                numbers.Add(num);
                n += 1;
            }
        }

        Console.WriteLine(n);
        Console.WriteLine(string.Join(",", numbers));

    }
}