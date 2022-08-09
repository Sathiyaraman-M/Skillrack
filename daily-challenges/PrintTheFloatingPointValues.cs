using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Trim();
        var result = "";
        foreach(var letter in input)
            if(char.IsNumber(letter) || letter == '.')
                result += letter.ToString();
            else
                result += " ";
        var doubles = result.Split(' ').Where(x => !string.IsNullOrEmpty(x) && x.Contains('.')).ToList();
        foreach(var value in doubles)
            Console.WriteLine(value);
    }
}