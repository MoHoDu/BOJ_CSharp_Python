using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class BJ1018
{
    public static void Main(string[] args)
    {
        int[] inputValue = (Console.ReadLine().Split().Select(t => int.Parse(t))).ToArray();
        int N = inputValue[0];
        int M = inputValue[1];

        string[] chessBoard = new string[N];
        string[] chessLine = new string[2] { "WBWBWBWB", "BWBWBWBW" };

        for (int i = 0; i < N; i++)
        {
            chessBoard[i] = Console.ReadLine();
        }

        List<int> diffrent = new List<int>();
        for (int k = 0; k < 2; k++)
        {
            for (int l = 0; M - l >= 8; l++)
            {
                for (int j = 0; N - j >= 8; j++)
                {
                    int curDiffrent = 0;
                    for (int d = 0; d < 8; d++)
                    {
                        string line = chessBoard[j + d];
                        line = line.Substring(l, 8);
                        string cLine = chessLine[(k + d) % 2];
                        int cd = 0;
                        for (int dd = 0; dd < 8; dd++)
                        {
                            if (line[dd] != cLine[dd])
                            {
                                curDiffrent++;
                                cd++;
                            }
                            if (d == 7 && dd == 7) diffrent.Add(curDiffrent);
                        }
                    }
                }
            }
        }

        Console.Write(diffrent.Min().ToString());
    }
}