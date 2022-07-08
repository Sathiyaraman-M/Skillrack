using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {        
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int R = tokens[0];
        int C = tokens[1];
        var M = new int[R, C];
        var queue = new Queue<int>(R * C);
        int healthy = 0, days = 0;
        for(int i = 0; i < R; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < C; j++)
            {
                M[i, j] = line[j];
                if(M[i, j] == 1) healthy++;
                else if(M[i, j] == 2) queue.Enqueue(i * C + j);
            }
        }
        queue.Enqueue(-1);
        while(queue.Any())
        {
            int currNode = queue.Dequeue();
            if(currNode == -1)
            {
                if(queue.Any())
                {
                    days++;
                    queue.Enqueue(-1);
                }
                continue;
            }
            if(col != 0 && M[row, col - 1] == 1)
            {
                M[row, col - 1] = 2;
                queue.Enqueue(row * C + col - 1);
                healthy--;
            }
            if(col != C - 1 && M[row, col + 1] == 1)
            {
                M[row, col + 1] = 2;
                queue.Enqueue(row * C + col + 1);
                healthy--;
            }
            if(row != 0 && M[row - 1, col] == 1)
            {
                M[row - 1, col] = 2;
                queue.Enqueue((row - 1) * C + col);
                healthy--;
            }
            if(row != R - 1 && M[row + 1, col] == 1)
            {
                M[row + 1, col] = 2;
                queue.Enqueue((row + 1) * C + col);
                healthy--;
            }
        }
        Console.Write(healthy == 0 ? days : -1);
    }
}