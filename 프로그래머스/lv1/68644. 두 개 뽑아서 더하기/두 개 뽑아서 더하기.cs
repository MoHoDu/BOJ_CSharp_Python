using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        List<int> answer = new List<int>();

        for (int n = 0; n < numbers.Length - 1; n++)
        {
            for (int m = n + 1; m < numbers.Length; m++)
            {
                int sum = numbers[n] + numbers[m];
                if (!answer.Contains(sum))
                {
                    answer.Add(sum);
                }
            }
        }

        answer.Sort();
        return answer.ToArray();
    }
}