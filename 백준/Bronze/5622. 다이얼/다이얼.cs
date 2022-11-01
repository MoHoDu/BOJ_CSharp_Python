using System;

public class Dial
{
    public static void Main(string[] args)
    {
        char[] text = Console.ReadLine().ToCharArray();
        int answer = 0;
        foreach (char t in text)
        {
            answer += Todial(t) + 1;
        }
        Console.Write($"{answer}\n");
    }

    public static int Todial(char c)
    {
        int charNum = Convert.ToInt32(c);
        int ANum = Convert.ToInt32('A');
        int answer = 0;

        int gap = charNum - ANum;
        if (gap < 3)
            answer = 2;
        else if (gap < 6)
            answer = 3;
        else if (gap < 9)
            answer = 4;
        else if (gap < 12)
            answer = 5;
        else if (gap < 15)
            answer = 6;
        else if (gap < 19)
            answer = 7;
        else if (gap < 22)
            answer = 8;
        else if (gap < 26)
            answer = 9;

        return answer;
    }
}