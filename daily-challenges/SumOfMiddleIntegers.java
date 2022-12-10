import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new int[N];
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
        }
        var half = N / 2;
        if(N % 2 == 0) {
            System.out.printf("%d", arr[half - 2] + arr[half - 1] + arr[half] + arr[half + 1]);
        } else {
            System.out.printf("%d", arr[half - 1] + arr[half] + arr[half + 1]);
        }
	}
}