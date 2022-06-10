using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        string[] line = Console.ReadLine().Split(' ');

        List<int> l = new List<int>();

        for (int i = 0; i < n; i++)
        {
            l.Add(Int32.Parse(line[i]));
        }
        int max = 0, maxi = 0, maxj = 0, maxl = 0, min = 0, maxInt = 0;
        for (int i = 0; i < n; i++)
        {
            int c = 0;
            min = l[i];
            maxInt = l[i];
            for (int j = i; j < n; j++)
            {
                if (Math.Abs(min - l[j]) < 2 && Math.Abs(maxInt - l[j]) < 2)
                {
                    min = Math.Min(min, l[j]);
                    maxInt = Math.Max(maxInt, l[j]);
                    c++;
                    maxj = j;
                }
                else
                {

                    break;
                }
            }
            //Console.WriteLine(c);
            if (max < c)
            {
                maxl = i + 1;
                max = c;
                maxi = maxj + 1;
            }
        }
        Console.WriteLine(maxl + " " + maxi);
    }
}