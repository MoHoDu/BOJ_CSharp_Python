using System;
using System.Collections.Generic;

public class SumClass
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string M = Console.ReadLine();
        int answer = 0;
        for (int idx = 0; idx < N; idx++)
        {
            string st = Convert.ToString(M[idx]);
            answer += int.Parse(st);
        }
        Console.WriteLine(answer);
    }
}