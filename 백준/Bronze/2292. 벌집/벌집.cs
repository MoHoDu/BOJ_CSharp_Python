using System;
using System.Collections.Generic;
using System.Linq;

public static class BJ2292
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int t = 2;
        int i = 0;

        while (t + 6 * i <= N)
        {
            t = t + 6 * i;
            i++;
        }

        Console.Write(i + 1);
    }
}