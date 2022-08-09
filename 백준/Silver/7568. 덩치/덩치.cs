using System;
using System.Collections.Generic;
using System.Linq;

public class BJ7566
{
    public static void Main(string[] args)
    {
        int caseN = int.Parse(Console.ReadLine());
        int[,] arr = new int[caseN, 3];
        for (int i = 0; i < caseN; i++)
        {
            string[] inpt = Console.ReadLine().Split();
            arr[i, 0] = int.Parse(inpt[0]);
            arr[i, 1] = int.Parse(inpt[1]);
            arr[i, 2] = 1;
        }

        for (int a = 0; a < caseN - 1; a++)
        {
            for (int b = a + 1; b < caseN; b++)
            {
                if (arr[a, 0] > arr[b, 0] && arr[a, 1] > arr[b, 1])
                {
                    arr[b, 2]++;
                }
                else if (arr[a, 0] < arr[b, 0] && arr[a, 1] < arr[b, 1])
                {
                    arr[a, 2]++;
                }
                else
                    continue;
            }
            Console.Write($"{arr[a, 2]} ");
        }
        Console.Write(arr[caseN - 1, 2]);
    }
}