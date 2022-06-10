using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    
    static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int c = 0;
        for(int i=0;i<n;i++)
            for(int j = i; j < n; j++) {
                int sum = 0;
                for (int g = i; g <= j; g++)
                    sum += numbers[g];
                if (sum == 0) c++;
            }
                
        Console.WriteLine(c);
    }
    
}