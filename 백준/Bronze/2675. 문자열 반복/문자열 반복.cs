using System;
using System.Collections.Generic;

public class StringsClass
{
    public static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        for (int count = 0; count < T; count++)
        {
            string[] inp = Console.ReadLine().Split();
            int repeatTime = int.Parse(inp[0]);
            string text = inp[1];
            for (int idx = 0; idx < text.Length; idx++)
            {
                for (int n = 0; n < repeatTime; n++)
                    Console.Write(text[idx]);
            }
            Console.Write("\n");
        }
    }
}