using System;
using System.Collections.Generic;
using System.Linq;

public static class BJ10250
{
    public static int answer = 0;

    public static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] strs = Console.ReadLine().Split().Select(t => t).ToArray();
            int H = int.Parse(strs[0]);
            int W = int.Parse(strs[1]);
            int N = int.Parse(strs[2]);

            int floor = (N % H) == 0 ? H * 100 : (N % H) * 100;
            int room = (N % H) == 0 ? (N / H) : (N / H) + 1;

            Console.WriteLine(floor + room);
        }
    }
}