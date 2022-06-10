using System;

public class Solution
{
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] x = new int[n];
        string[] s = Console.ReadLine().Split(' ');
        int sum = 0;//устанавливаем мин=макс
        int d = -1;
        //переводим в инт и находим sum
        for (int i = 0; i < n; i++)
        {
            x[i] = Int32.Parse(s[i]);
            d *= -1;
            sum += x[i]*d;
        }
        
        Console.WriteLine(sum);
    }
}