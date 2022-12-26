import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var success = false;
        for(int i = 0; i < N; i++) {
            var value = sc.nextInt();
            if((value * 2) % 10 != 2) {
                System.out.printf("%d ", value * 2);
                success = true;
            }
        }
        System.out.print(!success ? "-1" : "");
    }
}