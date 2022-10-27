using System;
using System.Collections.Generic;
using System.Linq;

public static class BJ1712
{
    public static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split().ToArray();
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        int C = int.Parse(S[2]);

        if (C <= B)
        {
            Console.WriteLine(-1);
            return;
        }

        int d = A / (C - B);
        Console.WriteLine(d + 1);
    }
}