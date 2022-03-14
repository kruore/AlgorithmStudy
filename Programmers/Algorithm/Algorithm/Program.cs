using System;

public class Program
{
    public int solution(string[,] clothes)
    {
        int answer = 1;

        // 각 타입별로 담을 딕셔너리
        Dictionary<string, List<string>> spy = new Dictionary<string, List<string>>();

        // 타입별로 딕셔너리에 저장
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            if (spy.ContainsKey(clothes[i, 1]) == false)
            {
                spy[clothes[i, 1]] = new List<string>();
            }

            spy[clothes[i, 1]].Add(clothes[i, 0]);
        }
        foreach (KeyValuePair<string, List<string>> cloth in spy)
        {
            answer *= cloth.Value.Count() + 1;
        }

        answer--;
        return answer;
    }
}
