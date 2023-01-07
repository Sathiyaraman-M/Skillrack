import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var X = sc.nextInt();
        var sum = 0;
        for(int i = 0; i < N; i++) {
            var value = sc.nextInt();
            sum += value + (value > X ? 1 : 0);
        }
        System.out.print(sum);
    }
}