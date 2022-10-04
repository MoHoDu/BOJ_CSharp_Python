using System;
using System.Collections.Generic;
using System.Linq;
// using System.Text;

public static class BJ2897
{
    public static void Main(string[] args)
    {
        int[] nm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        string[] problem = new string[n];

        for (int i = 0; i < n; i++)
        {
            problem[i] = Console.ReadLine();
        }

        int[] answer = new int[5];

        for (int y = 0; y < n - 1; y++)
        {
            for (int x = 0; x < m - 1; x++)
            {
                if (problem[y][x] != '#' && problem[y][x + 1] != '#')
                {
                    if (problem[y + 1][x] != '#' && problem[y + 1][x + 1] != '#')
                    {
                        string a = problem[y].Substring(x, 2);
                        string b = problem[y + 1].Substring(x, 2);
                        int count = a.Count(f => (f == 'X')) + b.Count(f => (f == 'X'));
                        answer[count]++;
                    }
                }
            }
        }

        // StringBuilder sb = new StringBuilder();
        for (int i = 0; i < answer.Length; i++)
        {
            // sb.Append(answer[i]);
            Console.WriteLine(answer[i]);
        }

        // Console.WriteLine(sb);
    }
}