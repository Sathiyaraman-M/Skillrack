using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Trim();
        int len = input.Length;
        var list = new List<string>();
        for(int i = 1; i < (1 << len); i++)
        {
            var builder = new StringBuilder();
            for(int j = 0; j < len; j++)
                if((i & (1 << j)) != 0)
                    builder.Append(input[j]);
            list.Add(builder.ToString());
        }
        list.Sort();
        foreach(var i in list)
            Console.WriteLine(i);
    }
}