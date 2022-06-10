using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
             int max = numbers.Max();
        for (int i = 0; i < n; i++)
            if (numbers[i] == max) numbers[i] /= 2;

            max = numbers.Max();
            for (int i = 0; i < n; i++)
                 if (numbers[i] == max) numbers[i] /= 2;
        Console.WriteLine(string.Join(" ", numbers));
    }
    
}