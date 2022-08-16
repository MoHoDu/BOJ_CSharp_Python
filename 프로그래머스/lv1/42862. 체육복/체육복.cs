using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        Array.Sort(lost);
        Array.Sort(reserve);

        foreach (int l in lost)
        {
            foreach (int r in reserve)
            {
                if (l == r)
                {
                    lost = lost.Where(x => x != l).ToArray();
                    reserve = reserve.Where(x => x != r).ToArray();
                }
            }
        }
        int answer = n - lost.Length;
        foreach (int l in lost)
        {
            for (int idx = 0; idx < reserve.Length; idx++)
            {
                if (reserve[idx] == l - 1 && reserve[idx] != -3
                    || reserve[idx] == l + 1 && reserve[idx] != -3)
                {
                    reserve[idx] = -3;
                    answer++;
                    break;
                }
            }
        }

        return answer;
    }
}