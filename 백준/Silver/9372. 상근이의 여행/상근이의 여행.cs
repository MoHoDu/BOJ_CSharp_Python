using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class BJ9372
{
    public static int[][] tree;
    public static bool[] visit;

    public static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < T; i++)
        {
            int[] integers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = integers[0];
            int m = integers[1];

            tree = new int[n + 1][];
            visit = Enumerable.Repeat<bool>(false, n + 1).ToArray();

            for (int ii = 0; ii < m; ii++)
            {
                int[] routes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (tree[routes[0]] == null || tree[routes[0]].Length == 0)
                    tree[routes[0]] = new int[] { routes[1] };
                else
                    tree[routes[0]] = tree[routes[0]].Concat(new int[] { routes[1] }).ToArray();

                if (tree[routes[1]] == null || tree[routes[1]].Length == 0)
                    tree[routes[1]] = new int[] { routes[0] };
                else
                    tree[routes[1]] = tree[routes[1]].Concat(new int[] { routes[0] }).ToArray();
            }

            sb.Append(DFS(1, 0) + "\n");
        }

        Console.WriteLine(sb);
    }

    public static int DFS(int idx, int answer)
    {
        visit[idx] = true;

        foreach (int i in tree[idx])
        {
            if (!visit[i])
            {
                answer = DFS(i, answer + 1);
            }
        }

        return answer;
    }
}