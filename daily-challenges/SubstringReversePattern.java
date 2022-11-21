import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var string = new Scanner(System.in).next().trim();
        int len = string.length();
        for(int i = 0; i <= len / 2; i++)
        {
            for(int j = 0; j < i; j++)
            {
                System.out.print('*');
            }
            if(i % 2 == 0)
            {
                for(int j = i; j < len - i; j++)
                {
                    System.out.print(string.charAt(j));
                }
            }
            else
            {
                for(int j = len - i - 1; j >= i; j--)
                {
                    System.out.print(string.charAt(j));
                }
            }
            System.out.println();
        }
	}
}