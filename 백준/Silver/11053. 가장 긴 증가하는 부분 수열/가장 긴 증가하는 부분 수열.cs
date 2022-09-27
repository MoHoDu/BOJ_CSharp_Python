using System;
using System.Collections.Generic;
using System.Linq;

public static class BJ11053
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.Write(LIS(array, N));
    }

    public static int LIS(int[] array, int n)
    {
        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] > array[j])
                    {
                        dp[i] = dp[j] >= dp[i] ? dp[j] + 1 : dp[i];
                    }
                }
            }
        }

        return dp.Max();
    }
}