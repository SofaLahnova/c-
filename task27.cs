using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static int[] Rev(int[] x, int l, int r)
    {
        while (l < r) {
            var c = x[r];
            
            x[r] = x[l];
            
            x[l] = c;
            l++;r--;
        }
        return x;
    }
    static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int l1 = a[0]-1;
        int l2 = b[0]-1;
        int r1 = a[1]-1;
        int r2 = b[1]-1;
        numbers = Rev(numbers, l1, r1);
        numbers = Rev(numbers, l2, r2);
        Console.WriteLine(string.Join(" ", numbers));
    }
    
}