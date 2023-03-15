using System;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Trim().Split(' ');
        var X = int.Parse(input[0]);
        var Y = int.Parse(input[2]);
        var ch = char.Parse(input[1]);
        int l = Math.Max(X, Y);
        int h = X + Y - 1;
        int lh = l - X, rh = l - Y, c = 0, d = h -1;
        for(int i = 0; i < l - 1; i++) {
            for(int j = 0; j < h; j++) {
                if(lh == i) {
                    if(c == j) {
                        Console.Write(ch);
                        c++;
                        lh++;
                    } else if(lh < l) {
                        Console.Write('-');
                    }
                } else if(rh == i) {
                    if(d == j) {
                        Console.Write(ch);
                        d--;
                        rh++;
                    } else {
                        if(rh < l) {
                            Console.Write('-');
                        }
                    }
                }
            }
            Console.WriteLine();
        }
        for(int i = 0; i < X; i++) {
            Console.Write(i == X - 1 ? ch : '-');
        }
    }
}