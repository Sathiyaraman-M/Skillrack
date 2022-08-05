using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static List<int> GetCountList(string word)
    {
        var list = new List<int>();
        for(int i = 0; i < word.Length - 1; i++)
            if (word[i] != word[i + 1])
                list.Add(i + 1);
        return list;
    }
    
    static void Main()
    {
        var input = Console.ReadLine().Trim();
        var counts = GetCountList(input);
        var list = Console.ReadLine().Trim().Split(' ').ToList();
        var result = new List<string>();
        foreach(var word in list)
        {
            if(word.Length == input.Length)
            {
                var currCount = GetCountList(word);
                int i = 0;
                while(i < counts.Count())
                {
                    if(counts[i] != currCount[i])
                        break;
                    i++;
                }
                if(i == counts.Count()) result.Add(word);
            }
        }
        if(!result.Any())
        {
            Console.WriteLine("-1");
            return;
        }
        foreach(var i in result)
            Console.Write(i + " ");
    }
}