using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class BJ2204
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            int count = int.Parse(Console.ReadLine());

            if (count == 0)
                break;

            List<string> strs = new List<string>();
            string answer = "";
            for (int i = 0; i < count; i++)
            {
                string a = Console.ReadLine();
                strs.Add(a);
            }
            answer = strs.OrderBy(t => t.ToLower()).Select(t => t).ToArray()[0];
            sb.Append(answer + "\n");
        }
        Console.WriteLine(sb);
    }
}