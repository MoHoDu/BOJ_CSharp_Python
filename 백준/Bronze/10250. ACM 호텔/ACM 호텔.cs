using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public static class BJtest
{
    public static StringBuilder sb = new StringBuilder();
    public static void Main(string[] args)
    {
        int testcase;
        int.TryParse(Console.ReadLine(), out testcase);
        // H W N
        for (int i = 0; i < testcase; i++)
        {
            int[] inputs = Console.ReadLine().Split().Select(t => int.Parse(t)).ToArray();
            int H = inputs[0];
            int W = inputs[1];
            int N = inputs[2];

            int newH = (N % H == 0 ? H : (N % H)) * 100;
            int newW = N % H == 0 ? (N / H) : (N / H) + 1;
            int room = newH + newW;

            sb.Append(room + "\n");
        }
        Console.Write(sb);
    }
}