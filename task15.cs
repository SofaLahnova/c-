using System;

    public class Solution
    {
    static bool Prost(int n)
    {
        bool prost = true;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                prost = false;
                break;
            }
        }
        return prost;
    }
        static void Main(string[] args)
        {
        int n = Int32.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            if (Prost(i)) Console.WriteLine(i);
        }
        
    }
    }
