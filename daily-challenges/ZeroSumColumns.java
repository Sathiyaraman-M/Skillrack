import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var M = new int[N][N];
        for(int i = 0; i < N; i++)
            for(int j = 0; j < N; j++)
                M[j][i] = sc.nextInt();
        for(int i = 0; i < N; i++)
        {
            var sum = 0;
            for(int j = 0; j < N; j++)
                sum += M[i][j];
            if(sum != 0)
            {
                System.out.print("no");
                return;
            }
        }
        System.out.print("yes");
	}
}