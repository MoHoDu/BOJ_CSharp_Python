using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class BJ2675
{
    public static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < T; i++)
        {
            string[] RS = Console.ReadLine().Split();
            int R = int.Parse(RS[0]);
            string S = RS[1];

            sb.Append(RepeatWords(R, S) + "\n");
        }

        Console.WriteLine(sb);
    }

    public static string RepeatWords(int r, string s)
    {
        string ss = "";
        foreach (char c in s)
        {
            string ns = new string(c, r);
            ss += ns;
        }

        return ss;
    }
}