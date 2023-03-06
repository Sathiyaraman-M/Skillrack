import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new int[N];
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
        }
        System.out.print((arr[1] - arr[0]) + " ");
        for(int i = 1; i < N - 1; i++) {
            var diff1 = arr[i - 1] - arr[i];
            var diff2 = arr[i + 1] - arr[i];
            System.out.print((diff1 < diff2 ? diff1 : diff2) + " ");
        }
        System.out.print((arr[N - 2] - arr[N - 1]) + " ");
    }
}