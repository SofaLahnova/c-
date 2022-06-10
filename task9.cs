using System;

    public class Solution
    {
        static void Main(string[] args)
        {
        int n = Int32.Parse(Console.ReadLine());
        int[] x = new int[n];
        string[] s = Console.ReadLine().Split(' ');
        int sum = 0;//устанавливаем мин=макс
        //переводим в инт и находим sum
        for (int i = 0; i < n; i++)
        {
            x[i] = Int32.Parse(s[i]);            
        }
        for (int i = 1; i <= n; i=i*2)
        {
            sum = sum + x[i - 1];
        }
        Console.WriteLine(sum);
        }
    }
