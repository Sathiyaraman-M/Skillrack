using System;

public class Program
{
    static bool IsVowel(char ch) => "aeiou".Contains(char.ToLower(ch));
    
    static void Main(string[] args)
    {
        int K = int.Parse(Console.ReadLine());
        var S = Console.ReadLine().Trim();
        int N = S.Length, Balance = 0;
        for(int i = 0; i < K; i++)
        {
            if(IsVowel(S[i])) Balance++;
            else Balance--;
        }
        int Count = Balance == 0 ? 1 : 0;
        for(int i = 1; i <= N - K; i++)
        {
            Balance += IsVowel(S[i - 1]) ? -1 : 1;
            Balance += IsVowel(S[i + K - 1]) ? 1 : -1;
            Count += Balance == 0 ? 1 : 0;
        }
        Console.WriteLine(Count);
    }
}