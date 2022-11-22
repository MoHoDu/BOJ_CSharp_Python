using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class BJ10816
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int[] intArray = new int[20000001];
        int N = int.Parse(Console.ReadLine());
        int[] cards = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int M = int.Parse(Console.ReadLine());
        int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < cards.Length; i++)
        {
            intArray[10000000 + cards[i]]++;
        }
        for (int j = 0; j < values.Length; j++)
        {
            sb.Append(intArray[10000000 + values[j]] + " ");
        }
        Console.Write(sb);
    }
}