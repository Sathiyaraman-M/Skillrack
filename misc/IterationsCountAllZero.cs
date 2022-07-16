using System;
using System.Linq;
 
namespace Hello
{
	class Hello
	{
	    static int[,] M;
	    static int R, C, K, iterations;
	    
	    static void Traverse(int x, int y)
	    {
	        if(x >= 0 && x < R && y >= 0 && y < C)
	        {
	            if(M[x, y] == 0)
	                return;
	            M[x, y] = 0;
	            Traverse(x, y - 1);
	            Traverse(x, y + 1);
	            Traverse(x + 1, y);
	            Traverse(x - 1, y);
	        }
	    }
	    
		public static void Main (string[] args)
		{
			var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
			R = tokens[0];
			C = tokens[1];
			M = new int[R, C];
			for(int i = 0; i < R; i++)
			{
			    var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
			    for(int j = 0; j < C; j++)
			        M[i, j] = line[j];
			}
			K = int.Parse(Console.ReadLine());
			for(int i = 0; i < R; i++)
			{
			    for(int j = 0; j < C; j++)
			    {
			        if(M[i, j] == K)
			        {
			            iterations++;
			            Traverse(i, j);
			        }
			    }
			}
			Console.Write(iterations);
		}
	}
}