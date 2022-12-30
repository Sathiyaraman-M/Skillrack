import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var X = sc.nextInt();
        var arr = new long[N];
        var success = false;
        for(int i = 0; i < N; i++) {
            var input = sc.nextLong();
            arr[i] = input * input + X;
            if (arr[i] % 10 != 5 && arr[i] % 10 != 6) {
                System.out.print(arr[i] + " ");
                if(!success) {
                    success = true;
                }
            }
        }
        if(!success) {
            System.out.print("-1");
        }
	}
}