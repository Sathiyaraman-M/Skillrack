import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var X = sc.nextInt();
        var sum = 0;
        for(int i = 0; i < N; i++) {
            var value = sc.nextInt();
            if(value % 10 == X) {
                sum += value;
            }
        }
        System.out.print(sum);
    }
}