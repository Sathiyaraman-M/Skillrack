using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var S1 = Console.ReadLine().Trim();
        var S2 = Console.ReadLine().Trim();
        var countArr = new int[S2.Length];
        for(int i = 0; i < S2.Length; i++)
            for(int j = 0; j < S1.Length; j++)
                if(S1[j] == S2[i])
                    countArr[i]++;
        Console.Write(countArr.Min());
    }
}