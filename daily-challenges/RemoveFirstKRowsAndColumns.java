import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var M = new int[N][N];
        for(int i = 0; i < N; i++) {
            for(int j = 0; j < N; j++) {
                M[i][j] = sc.nextInt();
            }
        }
        var K = sc.nextInt();
        for(int i = K; i < N; i++) {
            for(int j = K; j < N; j++) {
                System.out.print(M[i][j] + " ");
            }
            System.out.println();
        }
    }
}