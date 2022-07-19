using System;
using System.Linq;

public class Hello
{
	static void Main()
	{
		var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
		int R = tokens[0], C = tokens[1];
		var M = new long[R, C];
		for(int i = 0; i < R; i++)
		{
	        var line = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToList();
	        for(int j = 0; j < C; j++)
	            M[i, j] = line[j];
		}
		int Sum = M[0, 0];
		int currRow = 0;
		for(int i = 1; i < C; i++)
		{
            int max = 0, maxRow = currRow;
            for(int j = -1; j <= 1; j++)
            {
                if(currRow + j >=0  && currRow + j < R)
                {
                    if(max < M[currRow + j, i])
                    {
                        max = M[currRow + j, i];
                        maxRow = currRow + j;
                    }
                }
            }
            currRow = maxRow;
		    Sum += M[currRow, i];
		}
		Console.Write(Sum);
	}
}