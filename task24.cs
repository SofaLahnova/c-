using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int k = n / 2; int c = 0;
        for (int i = 0; i < k; i++)
            if (numbers[i] != numbers[n - 1 - i]) c++;
        Console.WriteLine(c);
    }

}