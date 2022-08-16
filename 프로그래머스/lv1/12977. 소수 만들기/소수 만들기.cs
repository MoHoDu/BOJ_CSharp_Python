using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int num1 = nums[i];
                    int num2 = nums[j];
                    int num3 = nums[k];
                    int sumN = (num1 + num2 + num3);

                    bool isPrime = true;
                    for (int n = 2; n <= MathF.Sqrt(sumN); n++)
                    {
                        if (sumN % n == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                        answer++;
                }
            }
        }

        return answer;
    }
}