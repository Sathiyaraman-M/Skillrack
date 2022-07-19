using System;
using System.Linq;
	
public class Hello
{
	static void Main()
	{
		var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
		int R = tokens[0], C = tokens[1], i = 0, j = 0;
		var M = new int[R, C];
		for(i = 0; i < R; i++)
		{
		    var lines = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
		    for(j = 0; j < C; j++)
		        M[i, j] = lines[j];
		}
		bool goUp = true;
		i = R - 1;
		j = C - 1;
		while(i != 0 || j != 0)
		{
		    if(i >= 0 && j >= 0)
		        Console.Write(M[i, j] + " ");
		    if(goUp)
		    {
		        i--;
		        j++;
		    }
		    else
		    {
		        i++;
		        j--;
		    }
		    if(i < 0 || j >= C)
		    {
		        if(i < 0)
		        {
		            i++;
		            j--;
		        }
		        j--;
		        goUp = !goUp;
		    }
		    else if(i >= R || j < 0)
		    {
		        if(j < 0)
		        {
		            i--;
		            j++;
		        }
		        i--;
		        goUp = !goUp;
		    }
		}
		Console.Write(M[i, j]);
	}
}