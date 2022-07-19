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
		bool goDown = false;
        i = 0;
        j = 0;
		while(i < R || j < C)
		{
		    if(i < R && j < C)
		        Console.Write(M[i, j] + " ");
		    if(goDown)
		    {
		        i++;
		        j--;
		    }
		    else
		    {
		        i--;
		        j++;
		    }
		    if(i >= R || j < 0)
		    {
		        if(i >= R) 
		        {
		            i--;
		            j++;
		        }
		        j++;
		        goDown = !goDown;
		    }
		    else if(i < 0 || j >= C)
		    {
		        if(j >= C)
		        {
		            i++;
		            j--;
		        }
		        i++;
		        goDown = !goDown;
		    }
		}
	}
}