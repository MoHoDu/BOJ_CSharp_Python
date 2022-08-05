using System;
using System.Collections.Generic;

namespace Baekjoon2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                    break;
                string[] inputs = input.Split();
                int A = int.Parse(inputs[0]);
                int B = int.Parse(inputs[1]);
                Console.WriteLine(A + B);
            }
        }
    }
}