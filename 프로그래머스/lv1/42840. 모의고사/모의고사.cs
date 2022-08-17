using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] answers)
    {
        List<int> result = new List<int>();
        // 배열 담아두기 - 찍는 번호들 1, 2, 3
        // students int[][]
        int[] person1 = new int[] { 1, 2, 3, 4, 5 };
        int[] person2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] person3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[][] student = new int[][] { person1, person2, person3 };

        int[] correct = new int[3];

        for (int idx = 0; idx < correct.Length; idx++)
        {
            for (int n = 0; n < answers.Length; n++)
            {
                int num = (n % student[idx].Length);
                
                if (student[idx][num] == answers[n])
                {
                    correct[idx]++;
                }
            }
        }
        foreach (int v in correct)
            Console.WriteLine(v);

        int maxValue = correct.Max();
        for (int i = 0; i < correct.Length; i++)
        {
            if (maxValue == correct[i])
            {
                result.Add(i+1);
            }
        }

        return result.ToArray();
    }
}