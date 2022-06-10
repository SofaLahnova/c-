using System;

public class Solution
{
    public static void Main()
    {
        string[] line = Console.ReadLine().Split(' ');
        int a = Int32.Parse(line[0]);
        int b = Int32.Parse(line[1]);
        int c = Int32.Parse(line[2]);
        int d = b * b - 4 * a * c;
        if (a != 0)
        {
            if (d < 0)
            {
                Console.WriteLine(0);
            }
            else if (d == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);

            }
        }
        else if (b != 0)
        {
            Console.WriteLine(1);
        }
        else if (c != 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(-1);
        }

    }
}