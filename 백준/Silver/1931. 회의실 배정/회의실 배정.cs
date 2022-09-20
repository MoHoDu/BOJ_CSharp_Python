using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class BJ1931
{
    public class Data
    {
        public int start { get; set; }
        public int end { get; set; }
    }

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Data[] data = new Data[N];

        for (int i = 0; i < N; i++)
        {
            string[] time = Console.ReadLine().Split(' ');
            data[i] = new Data { start = int.Parse(time[0]), end = int.Parse(time[1]) };
        }
        var timeTable = data.OrderBy(x => x.end).ThenBy(x => x.start).Select(x => x).ToArray();

        long endTime = 0;
        int answer = 0;
        for (int j = 0; j < N; j++)
        {
            if (timeTable[j].start < endTime)
                continue;
            else
            {
                answer++;
                endTime = timeTable[j].end;
            }
        }
        Console.Write(answer);
    }

}