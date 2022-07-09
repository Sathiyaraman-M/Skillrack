using System;
using System.Linq;

public class Program
{
    static int N;
    static int[,] M;
    static bool[] bishopRows, swDiagonals, nwDiagonals;

    static bool CanPlace(int row)
    {
        if(row == N)
            return true;
        if(bishopRows[row])
        {
            return CanPlace(row + 1);
        }
        for(int i = 0; i < N; i++)
        {
            if(!swDiagonals[i - row + N - 1] && !nwDiagonals[row + i])
            {
                M[row, i] = 1;
                bishopRows[row] = true;
                swDiagonals[i - row + N - 1] = true;
                nwDiagonals[i + row] = true;
                if(CanPlace(row + 1))
                {
                    return true;
                }
                else
                {
                    M[row, i] = 0;
                    bishopRows[row] = false;
                    swDiagonals[i - row + N - 1] = false;
                    nwDiagonals[i + row] = false;
                }
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        M = new int[N, N];
        bishopRows = new bool[N];
        swDiagonals = new bool[2 * N - 1];
        nwDiagonals = new bool[2 * N - 1];
        for(int i = 0; i < N; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < N; j++)
            {
                M[i, j] = line[j];
                if(M[i, j] == 1)
                {
                    bishopRows[i] = true;
                    swDiagonals[j - i + N - 1] = true;
                    nwDiagonals[j + i] = true;
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