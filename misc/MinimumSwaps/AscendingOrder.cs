using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> list;
    static int Count = 0;
    
    static void Swap(int index1, int index2)
    {
        var temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
        Count++;
    }
    
	static void Main()
	{
        int N = int.Parse(Console.ReadLine());
        list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        for(int i = N - 1; i >= 0; i--)
            if(list[i] != i + 1)
                Swap(list.IndexOf(i + 1), i);
        Console.Write(Count);
    }
}