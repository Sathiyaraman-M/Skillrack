using System;
using System.Linq;

public class Program
{
    static string s1, s2, s3;

    static int X => s1.Length;
    static int Y => s2.Length;
    static int X => s3.Length;

    static bool IsValidMix(int i, int j, int z)
    {
        while(k < Z)
        {
            if(i < X && j < Y && s1[i] == s3[k] && s2[j] && s3[k])
            {
                if(IsValidMix(i + 1, j, k + 1)) 
                    return true;
                return IsValidMix(i, j + 1, k + 1);
            }
            else if(i < X && s1[i] == s3[k])
            {
                i++; k++;                
            }
            else if(j < Y && s2[j] == s3[k])
            {
                j++; k++;
            }
            else return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        s1 = Console.ReadLine().Trim();
        s2 = Console.ReadLine().Trim();
        s3 = Console.ReadLine().Trim();
        Console.WriteLine(IsValidMix(0, 0, 0) ? "YES" : "NO");
    }
}