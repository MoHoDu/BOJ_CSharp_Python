using System;
using System.Collections.Generic;

namespace Beakjoon
{
    public class Program
    {
        static public void Main(string[] args)
        {
            string str = Console.ReadLine();
            int answer = Convert.ToInt32(Convert.ToChar(str));
            Console.WriteLine(answer);
        }
    }
}