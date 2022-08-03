using System;
using System.Collections.Generic;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayI;

            string[] input = Console.ReadLine().Split(' ');
            arrayI = new List<int>();

            foreach (string i in input)
            {
                arrayI.Add(int.Parse(i));
            }

            Console.Write(Price(arrayI));
        }

        static int Price(List<int> arrayInt)
        {
            int num = 0;
            int count = 0;

            foreach (int i in arrayInt)
            {
                if (arrayInt.Count(n => n == i) > count)
                {
                    num = i;
                    count = arrayInt.Count(n => n == i);
                }
                else if (arrayInt.Count(n => n == i) == count)
                {
                    num = i > num ? i : num;
                }
            }

            if (count == 3)
                return (10000 + num * 1000);
            else if (count == 2)
                return (1000 + num * 100);
            else
                return (num * 100);
        }
    }
}