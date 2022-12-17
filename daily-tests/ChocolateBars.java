import java.util.*;
public class Main
{
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var X = sc.nextInt();
        var N = sc.nextInt();
        var M = sc.nextInt();
        int Q = X / 5;
        var rem = X % 5;
        while(Q > M) {
            Q--;
            rem += 5;
        }
        System.out.printf("%d", rem);
    }
}