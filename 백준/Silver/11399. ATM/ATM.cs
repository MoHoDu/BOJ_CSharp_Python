using System;
using System.Collections.Generic;
using System.Linq;

public static class BJ11399
{
    public static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());
        string[] S = Console.ReadLine().Split().ToArray();
        List<int> P = new List<int>();

        foreach (string s in S)
            P.Add(int.Parse(s));
        P.Sort();

        int waitingTime = 0;
        for (int i = P.Count - 1; i >= 0; i--)
        {
            waitingTime += P[i] * (P.Count - i);
        }

        Console.WriteLine(waitingTime);
    }
}