using System;
using System.Linq;

public class Program
{
    static int R, C;
    
    static int[,] M;
    
    static bool IsHorizontallySymmetric()
    {
        for(int i = 0; i < C; i++)
            for(int j = 0; j < R / 2; j++)
                if(M[j, i] != M[R - j - 1, i])
                    return false;
        return true;
    }
    
    static bool IsVerticallySymmetric()
    {
        for(int i = 0; i < R; i++)
            for(int j = 0; j < C / 2; j++)
                if(M[i, j] != M[i, C - j - 1])
                    return false;
        return true;
    }
    
    static void Main()
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
        if(IsVerticallySymmetric() && IsHorizontallySymmetric())
            Console.Write("S");
        else if(IsHorizontallySymmetric())
            Console.Write("H");
        else if(IsVerticallySymmetric())
            Console.Write("V");
        else
            Console.Write("-1");
    }
}