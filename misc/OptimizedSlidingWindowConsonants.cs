using System;
/// <summary>
/// To calculate the consonants in each sliding window in O(n) time complexity
/// </summary>
public class Program
{
    static bool IsVowel(char ch) => "aeiou".Contains(char.ToLower(ch));
    
    static void Main(string[] args)
    {
        int K = int.Parse(Console.ReadLine());
        var S = Console.ReadLine().Trim();
        int N = S.Length;
        int Count = 0;
        for(int i = 0; i < K; i++)
        {
            if(!IsVowel(S[i])) Count++;
        }
        Console.Write(Count + " ");
        for(int i = 1; i <= N - K; i++)
        {
            if(!IsVowel(S[i - 1])) Count--;
            if(!IsVowel(S[i + K - 1])) Count++;
            Console.Write(Count + " ");
        }        
    }
}