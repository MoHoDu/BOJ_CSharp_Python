using System;
using System.Collections.Generic;
using System.Linq;

public class WordClass
{
    public static void Main(string[] args)
    {
        string text = (Console.ReadLine()).ToUpper();
        char[] words = new char[26];
        for (int i = 0; i < 26; i++)
        {
            words[i] = (char)(Convert.ToInt32('A') + i);
        }
        int maxCount = 0;
        char answer = '?';

        foreach (char word in words)
        {
            int c = text.Count(t => t == word);
            if (c > maxCount)
            {
                maxCount = c;
                answer = word;
            }
            else if (c == maxCount)
            {
                answer = '?';
            }
            else
            {
                continue;
            }
        }

        Console.Write(Convert.ToString(answer) + "\n");
    }
}