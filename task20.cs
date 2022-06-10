using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static void Main()
        {
            int pred, cur, k = 1;
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            var count = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
            if (i != n - 1)
            {
                pred = numbers[i + 1];
                cur = numbers[i];

                if (pred == cur)
                    k += 1;
                else
                {
                    count[cur] = k;
                    k = 1;
                }
            }
                else
                    count[numbers[i]] = k;
            }

            int maxValue = count.Values.Max();
            foreach (var num in count)
            {
                if (num.Value == maxValue)
                {
                    Console.WriteLine(num.Key + " " + maxValue);
                    break;
                }
            }

        }
    
}