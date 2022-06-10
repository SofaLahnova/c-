using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
   
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        List<int> r = new List<int>();
        int i = n-1;
        while (i>=0 && a[i]==9)
        {
            a[i] = 0;
            --i;
        }
        if (i >= 0)
        {
            a[i]++;
            Console.WriteLine(n);
            //объединяя в строку выводим
            Console.WriteLine(String.Join(" ", a));
        }
        else
        {
            r.Add(1);
            for (int j = 0; j < n; j++)
                r.Add(a[j]);
            n++;
            Console.WriteLine(n);
            //объединяя в строку выводим
            Console.WriteLine(String.Join(" ", r));
        }

        



    }
}
