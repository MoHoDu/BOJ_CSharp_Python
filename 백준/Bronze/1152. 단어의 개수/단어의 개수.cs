using System;

public class CountWord
{
    public static void Main(string[] args)
    {
        string[] sentence = Console.ReadLine().Split(' ');
        int answer = 0;
        foreach (string word in sentence)
        {
            answer = word != "" ? answer + 1 : answer;
        }
        Console.Write($"{answer}\n");
    }
}