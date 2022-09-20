using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class BJ4375
{
    public static void Main(string[] args)
    {
        int num;
        while (true)
        {
            string s = Console.ReadLine();
            if (s == null)
                break;

            num = int.Parse(s);
            if (num % 2 == 0 || num % 5 == 0)
                break;

            Solve(num);
        }
    }

    public static void Solve(int num, int one = 1, int result = 1)
    {
        if (one % num == 0)
            Console.WriteLine(result);
        else
        {
            Solve(num, (one % num) * 10 + 1, result + 1);
        }
    }
}