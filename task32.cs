using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
   
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int m = Int32.Parse(Console.ReadLine());
        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int i = 0;
        if (n == m)
        {
            while (i < n && a[i] == b[i] )
                i++;
            if (i == n) Console.WriteLine(0);
            else if (a[i] > b[i]) Console.WriteLine(1);
            else Console.WriteLine(-1);
        }
        else if (n<m) Console.WriteLine(-1);
        else Console.WriteLine(1);



    }
}
