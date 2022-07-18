using System;
using System.Linq;

class Hello
{
	public static void Main (string[] args)
	{
		int N = int.Parse(Console.ReadLine());
		var list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
		int minPrice = list[0], maxProfit = 0;
		for(int i = 1; i < N; i++)
		{
		    if(list[i] < minPrice)
		        minPrice = list[i];
		    else
		    {
		        int profit = list[i] - minPrice;
		        if(profit > maxProfit) maxProfit = profit;
		    }
		}
		Console.Write(maxProfit);
	}
}