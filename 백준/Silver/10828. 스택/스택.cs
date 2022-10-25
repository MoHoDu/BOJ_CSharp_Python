using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class BJ10828
{
    public static List<int> stack = new List<int>();
    public static StringBuilder sb = new StringBuilder();

    public static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCase; i++)
        {
            string strs = Console.ReadLine();
            Stack(strs);
        }
        Console.WriteLine(sb);
    }

    public static void Stack(string str)
    {
        if (str.Contains(" "))
        {
            string[] strs = str.Split().Select(t => t).ToArray();
            Push(int.Parse(strs[1]));
        }
        else
        {
            switch (str)
            {
                case "pop":
                    // Console.WriteLine(Pop());
                    sb.Append(Pop() + "\n");
                    break;
                case "size":
                    // Console.WriteLine(Size());
                    sb.Append(Size() + "\n");
                    break;
                case "empty":
                    // Console.WriteLine(Empty());
                    sb.Append(Empty() + "\n");
                    break;
                case "top":
                    // Console.WriteLine(Top());
                    sb.Append(Top() + "\n");
                    break;
            }
        }
    }

    public static void Push(int x)
    {
        stack.Add(x);
    }

    public static int Pop()
    {
        int popValue = Top();
        if (popValue != -1)
            stack.RemoveAt(stack.Count - 1);
        return popValue;
    }

    public static int Size()
    {
        return stack.Count;
    }

    public static int Empty()
    {
        if (stack.Count == 0) return 1;
        return 0;
    }

    public static int Top()
    {
        if (Empty() == 1)
            return -1;
        return stack[stack.Count - 1];
    }
}