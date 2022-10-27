using System;
using System.Collections.Generic;
using System.Linq;

public static class BJ11047_2
{
    public static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split().ToArray();
        int N = int.Parse(S[0]);
        int K = int.Parse(S[1]);
        List<int> money = new List<int>();

        for (int i = 0; i < N; i++)
            money.Add(int.Parse(Console.ReadLine()));

        int count = 0;
        for (int i = money.Count - 1; i >= 0; i--)
        {
            if (K <= 0)
                break;

            if (money[i] > K)
                continue;
            else
            {
                count += (K / money[i]);
                K %= money[i];
            }
        }

        Console.WriteLine(count);
    }
}