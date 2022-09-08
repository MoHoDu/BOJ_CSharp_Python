using System;
using System.Collections.Generic;

public static class BJ2609
{
    public static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split(" ");
        int a = int.Parse(str[0]);
        int b = int.Parse(str[1]);

        int gcd = SolveGCD(a, b);
        int lcm = SolveLCM(a, b, gcd);

        Console.Write(gcd + "\n" + lcm);
    }

    public static int SolveGCD(int a, int b)
    {
        int big;
        int small;
        if (a > b)
        {
            big = a;
            small = b;
        }
        else
        {
            big = b;
            small = a;
        }

        int r = big % small;
        if (r == 0)
        {
            return small;
        }
        else
        {
            return SolveGCD(small, r);
        }
    }

    public static int SolveLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }
}