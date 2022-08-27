using System;
using System.Linq;

public class Program
{
    static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
    
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').ToList();
        var N = int.Parse(tokens[1]);
        var list = tokens[0].Where(x => !IsVowel(x)).ToList();
        for(int i = 0; i < N; i++)
        {
            list.Add(list.First());
            list.Remove(list.First());
        }
        int index = 0;
        foreach(var i in tokens[0])
            Console.Write(IsVowel(i) ? i : list[index++]);
    }
}