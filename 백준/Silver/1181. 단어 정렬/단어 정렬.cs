using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class BJ1181
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();

        for (int i = 0; i < N; i++)
        {
            string word = Console.ReadLine();
            if (!words.Contains(word))
                words.Add(word);
        }

        var array = words.OrderBy(x => x.Length).ThenBy(x => x).Select(x => x).ToArray();
        foreach (string w in array)
            Console.WriteLine(w);
    }
}