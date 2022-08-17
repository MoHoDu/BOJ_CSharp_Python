using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];

        int sumN = brown + yellow;

        for (int i = 1; i <= MathF.Sqrt(sumN); i++)
        {
            if (sumN % i == 0)
            {
                int a = (sumN / i);
                int b = i;
                if ((a - 2) * (b - 2) == yellow)
                {
                    answer[0] = (int)MathF.Max(a, b);
                    answer[1] = (int)MathF.Min(a, b);
                }
            }
        }

        return answer;
    }
}