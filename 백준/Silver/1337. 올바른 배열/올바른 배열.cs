using System;
using System.Collections.Generic;
using System.Linq;

public static class BJ1337
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int[] sorted_arr = arr.OrderBy(x => x).Distinct().ToArray();
        Console.Write(LIS(sorted_arr));
    }

    public static int LIS(int[] arr)
    {
        int[] dp = new int[arr.Length];
        for (int n = 0; n < arr.Length; n++)
        {
            if (n == 0)
                dp[n] = 4;
            else
            {
                dp[n] = 4;
                for (int i = 1; i <= (5 - dp[n - 1]); i++)
                {
                    if (arr[n - i] > (arr[n] - 5))
                        dp[n] -= 1;
                    else
                        break;
                }
            }
        }

        return dp.Min();
    }
}

