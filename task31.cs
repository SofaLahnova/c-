using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
   
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int k = 0;
        List<int> r = new List<int>();
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int[] count = new int[101];
        
        for (int i = 0; i < n; i++)
        {
            count[numbers[i]]++;
        }
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > 1)
            {
                k++;
            }
        }
//выводим кол-во
        Console.WriteLine(k);
        
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > 1)
            {
                Console.Write(i + " ");
            }
        }
        
       

    }
}
