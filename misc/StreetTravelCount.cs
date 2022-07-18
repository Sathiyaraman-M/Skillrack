using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static int N;
    static int[,] M;
    static bool[] visited;

    static List<int> GetNearbyNodes(int node)
    {
        var list = new List<int>();
        int row = node / N;
        int col = node % N;
        for(int i = row; i < N; i++)
        {
            if(M[i, col] == 1) list.Add(i * N + col);
            else break;
        }
        for(int i = row; i >= 0; i--)
        {
            if(M[i, col] == 1) list.Add(i * N + col);
            else break;
        }
        for(int i = col; i < N; i++)
        {
            if(M[row, i] == 1) list.Add(row * N + i);
            else break;
        }
        for(int i = col; i >= 0; i--)
        {
            if(M[row, i] == 1) list.Add(row * N + i);
            else break;
        }
        return list;
    }

    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine().Trim());
        M = new int[N, N];
        for(int i = 0; i < N; i++)
        {
            var line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for(int j = 0; j < N; j++)
            {
                M[i, j] = line[j];
            }
        }
        var srcCoords = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        var destCoords = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        int src = srcCoords[0] * N + srcCoords[1];
        int dest = destCoords[0] * N + destCoords[1];
        var queue = new Queue<int>(N * N);
        visited = new bool[N * N];
        var streets = new int[N * N];
        queue.Enqueue(src);
        streets[src] = 0;
        visited[src] = true;
        while(queue.Any())
        {
            int currNode = queue.Dequeue();
            var list = GetNearbyNodes(currNode);
            for(int i = 0; i < list.Count; i++)
            {
                var node = list[i];
                if(visited[node]) continue;
                queue.Enqueue(node);
                streets[node] = streets[currNode] + 1;
                visited[node] = true;
                if(node == dest)
                {
                    Console.Write(streets[node]);
                    return;
                }                
            }
        }
    }
}