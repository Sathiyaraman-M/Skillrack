using System;
using System.Linq;

public class Program
{
    static bool IsValidTriangle(int x, int y, int z)
    {
        if(x == 0 || y == 0 || z == 0)
            return false;
        return (x + y > z || y + z > x || x + z > y) && x + y + z == 180;
    }
    
    static void Main()
    {
        var tokens = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
        Console.Write(IsValidTriangle(tokens[0], tokens[1], tokens[2]) ? "Valid triangle" : "Not a valid triangle");
    }
}