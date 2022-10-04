using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int num = (n * (n + 1) / 2);
        int[] answer = new int[num];

        int tri = 0;
        int dir = 1;
        int count = 0;

        int i = 0;
        int maxCount = (n - (3 * tri));

        for (int v = 1; v <= num; v++)
        {
            answer[i] = v;

            count++;

            if (count == maxCount)
            {
                if (dir == -1)
                {
                    dir = 1;
                    tri++;
                    maxCount = (n - (3 * tri));
                }
                else
                {
                    dir--;
                    maxCount--;
                }
                count = 0;
            }

            switch (dir)
            {
                case 1:
                    i += (2 * tri) + (count);
                    break;
                case 0:
                    i += 1;
                    break;
                case -1:
                    i -= (n - tri) - (count);
                    break;
            }
        }
        
        return answer;
    }
}
