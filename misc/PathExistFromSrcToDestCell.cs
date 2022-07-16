using System;
using System.Linq;

public class Program
{
    static int[,] M;
    static int R, C, srcR, srcC, destR, destC;
    static bool Found = false;

    static void Traverse(int x, int y)
    {
        if(x >= 0 && x < R && y >= 0 && y < C)
        {
            if(x == destR && y == destC)
            {
                Found = true;
                return;
            }
            if(M[x, y] == 0 || M[x, y] == 2)
                return;
            M[x, y] = 2;
            Traverse(x, y - 1);
            if(!Found) Traverse(x, y + 1);
            if(!Found) Traverse(x + 1, y);
            if(!Found) Traverse(x - 1, y);
        }
    }

    static void Main(string[] args)
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
        var list1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var list2 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        srcR = list1[0];
        srcC = list1[1];
        destR = list2[0];
        destC = list2[1];
        Traverse(srcR, srcC);
        Console.Write(Found ? "yes" : "no");
    }
}