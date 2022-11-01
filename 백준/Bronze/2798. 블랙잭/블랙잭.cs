using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class BJ2798
{
    public static void Main(string[] args)
    {
        int[] tm = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        nums = nums.OrderBy(t => t).ToArray();

        int answer = 0;
        for (int i = 0; i < tm[0] - 2; i++)
        {
            for (int j = i + 1; j < tm[0] - 1; j++)
            {
                for (int k = tm[0] - 1; k > j; k--)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == tm[1])
                    {
                        answer = sum;
                        Console.WriteLine(answer);
                        return;
                    }
                    else if (sum < tm[1])
                    {
                        if (answer < sum)
                            answer = sum;
                        break;
                    }
                }
            }
        }

        Console.WriteLine(answer);
    }
}