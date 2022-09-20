using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) 
    {
        return Answer(strings, n);
    }
    
    public static string[] Answer(string[] words, int n)
    {
        var answer = words.OrderBy(x => x[n]).ThenBy(x => x).Select(x => x).ToArray();
        return answer;
    }
}