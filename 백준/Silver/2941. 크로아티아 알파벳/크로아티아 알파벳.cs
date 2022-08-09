using System;
using System.Collections.Generic;
using System.Linq;

public class CroAlpha
{
    public static void Main(string[] args)
    {
        string centence = Console.ReadLine();
        int answer = 0;

        // string[] CroToAlpha = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
        int croInSentence = 0;
        for (int idx = 1; idx < centence.Length; idx++)
        {
            if (centence[idx] == '=')
            {
                switch (centence[idx - 1])
                {
                    case ('c'):
                        answer++;
                        croInSentence += 2;
                        break;
                    case ('z'):
                        if (idx >= 2 && centence[idx - 2] == 'd')
                        {
                            answer++;
                            croInSentence += 3;
                        }
                        else
                        {
                            answer++;
                            croInSentence += 2;
                        }
                        break;
                    case ('s'):
                        answer++;
                        croInSentence += 2;
                        break;
                }
            }
            else if (centence[idx] == '-')
            {
                switch (centence[idx - 1])
                {
                    case ('c'):
                        answer++;
                        croInSentence += 2;
                        break;
                    case ('d'):
                        answer++;
                        croInSentence += 2;
                        break;
                }
            }
            else if (centence[idx] == 'j')
            {
                switch (centence[idx - 1])
                {
                    case ('l'):
                        answer++;
                        croInSentence += 2;
                        break;
                    case ('n'):
                        answer++;
                        croInSentence += 2;
                        break;
                }
            }
        }
        answer += centence.Length - croInSentence;
        Console.Write($"{answer}\n");
    }
}