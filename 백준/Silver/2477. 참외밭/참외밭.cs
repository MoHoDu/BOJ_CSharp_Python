using System;
using System.Collections.Generic;

public class BJ2477
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string[] inpts = new string[6];
        for (int i = 0; i < 6; i++)
        {
            inpts[i] = Console.ReadLine();
        }
        Console.Write($"{SolveExtent(inpts) * num}\n");
    }

    public static int SolveExtent(string[] inpts)
    {
        int maxX = 0;
        int maxY = 0;
        int Extent = 0;
        foreach (string s in inpts)
        {
            string[] i = s.Split(' ');
            switch (int.Parse(i[0]))
            {
                case (1):
                case (2):
                    if (maxX < int.Parse(i[1]))
                        maxX = int.Parse(i[1]);
                    break;
                case (3):
                case (4):
                    if (maxY < int.Parse(i[1]))
                        maxY = int.Parse(i[1]);
                    break;
            }
        }

        Extent = maxX * maxY;
        int[] inp = new int[6];
        for (int i = 0; i < 6; i++)
            inp[i] = int.Parse(inpts[i].Split(' ')[1]);

        for (int i = 0; i < 6; i++)
        {
            if (inp[i] != maxX && inp[i] != maxY)
            {
                if (i == 0)
                {
                    if (inp[5] == maxX || inp[5] == maxY)
                    {
                        Extent -= inp[1] * inp[2];
                        break;
                    }
                }
                else if (inp[i - 1] == maxX || inp[i - 1] == maxY)
                {
                    Extent -= inp[(i + 1) % 6] * inp[(i + 2) % 6];
                    break;
                }
            }
        }
        return Extent;
    }
}
