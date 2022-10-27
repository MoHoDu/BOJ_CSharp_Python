using System;
using System.Collections.Generic;
using System.Linq;

public static class BJ10870
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(fibonacci(N));
    }

    public static int fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
        {
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}