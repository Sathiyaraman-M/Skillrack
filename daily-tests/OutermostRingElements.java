import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var R = sc.nextInt();
        var C = sc.nextInt();
        var mat = new int[R][C];
        for(int i = 0; i < R; i++)
            for(int j = 0; j < C; j++)
                mat[i][j] = sc.nextInt();
        for(int i = 0; i < R; i++) {
            for(int j = 0; j < C; j++) {
                if (i == 0 || i == R - 1 || j == 0 || j == C - 1) {
                    System.out.print(mat[i][j] + " ");
                } else {
                    System.out.print("* ");
                }
            }
            System.out.println();
        }
    }
}