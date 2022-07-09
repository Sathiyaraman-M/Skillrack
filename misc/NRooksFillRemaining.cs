using System;
using System.Linq;

public class Program
{
    static int N;
    static int[,] M;
    static bool[] rookRows, rookCols;

    static bool CanPlace(int row)
    {
        if(row == N)
            return true;
        if(rookRows[row])
        {
            return CanPlace(row + 1);
        }
        for(int i = 0; i < N; i++)
        {
            if(!rookCols[i])
            {
                M[row, i] = 1;
                rookRows[row] = true;
                rookCols[i] = true;
                if(CanPlace(row + 1))
                {
                    return true;
                }
                else
                {
                    M[row, i] = 0;
                    rookRows[row] = false;
                    rookCols[i] = false;
                }
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        M = new int[N, N];
        rookRows = new bool[N];
        rookCols = new bool[N];
        for(int i = 0; i < N; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < N; j++)
            {
                M[i, j] = line[j];
                if(M[i, j] == 1)
                {
                    rookRows[i] = true;
                    rookCols[j] = true;
                }
            }
        }
        if(CanPlace(0))
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.Write("NotPossible");
        }
    }
}