using System;
using System.Linq;

public class Program
{
    static void Main()
	{
		int N = int.Parse(Console.ReadLine());
		var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
		int maxProfit = 0;
		for(int i = 1; i < N; i++)
		    if(list[i] > list[i - 1])
		        maxProfit += list[i] - list[i - 1];
		Console.Write(maxProfit);
	}
}