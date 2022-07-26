using System;

public class Program 
{
    static void Main() 
    {
        var tokens = Console.ReadLine().Trim().Split(' ');
        var s1 = tokens[0].Trim();
        var s2 = tokens[1].Trim();
		var map = new int[128];
		for(var c in s2)
            map[c] += 1;
        int start = 0, count = s2.Length;
        int len = int.MaxValue;
        for(int i = 0, j = 0; j < s1.Length; j++)
        {
            var c = s1[j];
            map[c]--;
            if (map[c] >= 0) 
                count--;
            while(count == 0)
            {
                char left = s1[i];
                map[left]++;
                if(map[left] > 0)
                {
                    if(j + 1 - i < len)
                    {
                        start = i;
                        len = j - i + 1;
                    }
                    count++;
                }
                i++;
            }
        }
        Console.Write(len == int.MaxValue ? "-1" : s1.Substring(start, len));
	}
}