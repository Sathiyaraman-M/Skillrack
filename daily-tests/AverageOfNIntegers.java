import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var sum = 0;
        for(int i = 0; i < N; i++) {
            sum += sc.nextInt();
        }
        System.out.printf("%.2f", (float)(sum) / N);
    }
}