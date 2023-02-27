import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var M = sc.nextInt();
        var N = sc.nextInt();
        for(int i = 0; i < M; i++) {
            var sum = 0;
            for(int j = 0; j < N; j++) {
                var temp = sc.nextInt();
                sum += temp;
                System.out.print(temp + " ");
            }
            System.out.println(sum);
        }
        sc.close();
    }
}