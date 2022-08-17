using System;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[,] sizes)
    {
        int answer = 0;
        int maxW = 0;
        int maxH = 0;
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int width = (int)MathF.Max(sizes[i, 0], maxW);
            int height = (int)MathF.Max(sizes[i, 1], maxH);

            int width2 = (int)MathF.Max(sizes[i, 1], maxW);
            int height2 = (int)MathF.Max(sizes[i, 0], maxH);

            if ((width * height) <= (width2 * height2))
            {
                maxW = width;
                maxH = height;
                answer = (width * height);
            }
            else
            {
                maxW = width2;
                maxH = height2;
                answer = (width2 * height2);
            }
        }

        return answer;
    }
}