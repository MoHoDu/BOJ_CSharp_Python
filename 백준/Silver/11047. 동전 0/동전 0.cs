using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class BJ11047
{
    public static void Main(string[] args)
    {
        int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = inputs[0];
        int m = inputs[1];
        int result = 0;
        // Console.WriteLine($"{n} {m} {result}");

        List<int> wallet = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int money = int.Parse(Console.ReadLine());
            wallet.Add(money);
        }

        wallet.Reverse();
        int j = 0;
        while (m != 0)
        {
            if (wallet[j] <= m)
            {
                result += (m / wallet[j]);
                m = m % wallet[j];
                // Console.WriteLine($"{m} {result}");
            }

            j++;
        }

        Console.WriteLine(result);
    }

}

// 4200
// 1000 * 4 --> 200
// 100 * 2 --> 0

// 4790
// 1000 * 4 --> 790
// 500 * 1 --> 290
// 100 * 2 --> 90
// 50 * 1 --> 40
// 10 * 4 --> 0