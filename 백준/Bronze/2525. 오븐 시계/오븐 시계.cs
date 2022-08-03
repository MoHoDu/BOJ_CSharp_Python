using System;
using System.Collections.Generic;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] A = Console.ReadLine().Split(' ');
            int C = int.Parse(Console.ReadLine());
            int hour = int.Parse(A[0]);
            int minute = int.Parse(A[1]) + C;
            if (minute >= 60)
            {
                int newHour = hour + (int)(minute / 60);
                hour = newHour > 23 ? newHour - 24 : newHour;
                minute %= 60;
            }
            Console.Write($"{hour} {minute}");
        }
    }
}