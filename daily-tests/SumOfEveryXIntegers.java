import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        int N = sc.nextInt();
        var list = new int[N];
        for(int i = 0; i < N; i++)
            list[i] = sc.nextInt();
        int X = sc.nextInt();
        for(int i = 0; i < N; i += X)
        {
            var sum = 0;
            for(int j = 0; j < X; j++)
                sum += list[i + j];
            System.out.print(sum + " ");
        }
	}
}