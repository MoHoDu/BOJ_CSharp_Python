using System;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        int[] answer = new int[id_list.Length];
        int[] result = new int[id_list.Length];
        Dictionary<string, List<string>> reported = new Dictionary<string, List<string>>();
        foreach (string id in id_list)
        {
            reported.Add(id, new List<string>());
        }
        for (int i = 0; i < report.Length; i++)
        {
            string[] r = report[i].Split(" ");
            string id = r[0];
            string reported_id = r[1];
            if (!reported[id].Contains(reported_id))
            {
                reported[id].Add(reported_id);
                for (int e = 0; e < id_list.Length; e++)
                {
                    if (id_list[e] == reported_id)
                    {
                        result[e]++;
                        break;
                    }
                }
            }
        }

        for (int idx = 0; idx < result.Length; idx++)
        {
            if (result[idx] >= k)
            {
                int n = 0;
                foreach (KeyValuePair<string, List<string>> item in reported)
                {
                    if (item.Value.Contains(id_list[idx]))
                    {
                        answer[n]++;
                    }
                    n++;
                }
            }
        }

        return answer;
    }
}