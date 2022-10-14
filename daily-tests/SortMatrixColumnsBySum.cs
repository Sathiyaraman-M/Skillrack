using System;
using System.Collections.Generic;
using System.Linq;

public class Hello
{   
    static void Main()
	{
		var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
		int R = tokens[0], C = tokens[1];
		var M = new List<List<int>>();
		for(int i = 0; i < R; i++)
		    M.Add(Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList());
		var newM = new List<List<int>>();
		for(int i = 0; i < C; i++)
		{
		    var list = new List<int>();
		    for(int j = 0; j < R; j++)
		        list.Add(M[j][i]);
            newM.Add(list);
		}
		for(int i = 0; i < R - 1; i++)
		{
		    var key = newM[i];
		    for(int j = i + 1; j < R; j++)
		    {
		        if(newM[j].Sum() < key.Sum())
		        {
		            var temp = newM[j];
		            newM[j] = key;
		            key = temp;
		        }
		    }
		}
		for(int i = 0; i < R; i++)
		{
		    for(int j = 0; j < C; j++)
		        Console.Write(newM[j][i] + " ");
		    Console.WriteLine();
		}
	}
}