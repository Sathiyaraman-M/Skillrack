using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static string Swapped(string str, int i, int j)
    {
        var arr = str.ToCharArray();
        var temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        return new string(arr);
    }
    
    static void Permute(string s, int l, int r)
    {
        if(l == r)
        {
            Console.Write(s + " ");
            return;
        }
        for(int i = l; i <= r; i++)
        {
            s = Swapped(s, i, l);
            Permute(s,  i + 1, l);
            s = Swapped(s, i, l);
        }
    }
    
    static void Main()
    {
        var N = Console.ReadLine().Trim();
        var X = int.Parse(Console.ReadLine());
        var list = new List<int>();
        int len = N.Length;
        for(int i = 0; i <= len; i++)
        {
            for(int j = 1; j < i + 1; j++)
            {
                var builder = new StringBuilder();
                for(int k = 0; k < j; k++)
                    builder.Append(N[k]);
                list.Add(int.Parse(builder.ToString()));
            }
        }
        list.Sort();
        foreach(var i in list.Distinct().OrderBy(x => x.ToString().Length))
            Console.Write(i + " ");
        Console.WriteLine($"\nX: {list.Count > X ? list[X + 1] : -1}");
    }
}