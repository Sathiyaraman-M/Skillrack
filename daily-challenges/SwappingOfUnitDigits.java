import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        int N = sc.nextInt();
        var arr = new int[N];
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
        }
        for(int i = 0; i < N / 2; i++) {
            var rem1 = arr[i] % 10;
            var rem2 = arr[N - i - 1] % 10;
            arr[i] = arr[i] - rem1 + rem2;
            arr[N - i - 1] = arr[N - i - 1] - rem2 + rem1;
        }
        for(int i: arr) {
            System.out.print(i + " ");
        }
	}
}