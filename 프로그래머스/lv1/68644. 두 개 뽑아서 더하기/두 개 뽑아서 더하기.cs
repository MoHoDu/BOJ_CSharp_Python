using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[numbers.Length * 2];
        
        int n = 0;
        for (int j = 0; j < numbers.Length; j++)
        {
            for (int k = j + 1; k < numbers.Length; k++)
            {
                int num = numbers[j] + numbers[k];

                if (!answer.Contains(num))
                {
                    answer[n] = num;
                    n++;
                }
            }
        }
        Array.Resize(ref answer, n);
        Array.Sort(answer);
        return answer;
    }
}