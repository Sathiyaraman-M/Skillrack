import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var sum = 0;
        for(int i = 0; i < N; i++) {
            var val = sc.nextInt();
            sum += val >= 0 ? val : -val;
        }
        System.out.print(sum);
    }
}