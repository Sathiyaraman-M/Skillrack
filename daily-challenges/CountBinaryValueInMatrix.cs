using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    static int GetCount(string[] arr, string bin)
    {
        int count = 0;
        foreach(var value in arr)
        {
            for(int i = 0; i < value.Length - bin.Length + 1; i++)
            {
                int j = 0;
                while(j < bin.Length && value[i + j] == bin[j]) 
                    j++;
                if(j == bin.Length)
                    count++;
            }
        }
        return count;
    }
    
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int R = tokens[0], C = tokens[1];
        for(int i = 0; i < R; i++)
            arr[i] = new string(Console.ReadLine().Trim().Split(' ').Select(x => char.Parse(x.Trim())).ToArray());
        int N = int.Parse(Console.ReadLine());
        int pos = 1;
        string bin = "";
        while(pos <= N)
        {
            var digit = (N & pos) != 0 ? "1" : "0";
            bin = digit + bin;
            pos *= 2;
        }
        var transpose = new string[C];
        for(int i = 0; i < C; i++)
        {
            var rowStr = "";
            for(int j = 0; j < R; j++)
                rowStr += arr[j][i];
            transpose[i] = rowStr;
        }
        int count = GetCount(arr, bin) + GetCount(transpose, bin);
        Console.WriteLine(count);
    }
}