using System;
using System.Collections.Generic;
using System.Linq;

public static class BJ1065
{
    // public static List<int> stack = new List<int>();
    public static int answer = 0;

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        if (N < 100)
        {
            answer = N;
            Console.Write(answer);
        }
        else if (N <= 110)
        {
            answer = 99;
            Console.Write(answer);
        }
        else
        {
            answer = 99;
            for (int i = 111; i < N + 1; i++)
            {
                int first = (i / 100);
                int second = (i % 100) / 10;
                int third = (i % 100) % 10;

                if ((first - second) == (second - third))
                    answer++;
            }

            Console.Write(answer);
        }
    }
}