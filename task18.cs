using System;

public class Solution
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int i = 0, c = 1, sum = 0, z = 1, r = 0 ;
        while (i < n)
        {
            if (r == c) { z *= -1; c++; r = 1; }
            else r++;            
            sum += x[i] * z;
            i++;
        }
         Console.WriteLine(sum);
        
    }
}