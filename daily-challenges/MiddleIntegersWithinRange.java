import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new int[N];
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
        }
        for(int i = 1; i < N - 1; i++) {
            if(arr[i] <= arr[0] || arr[i] >= arr[N - 1]) {
                System.out.print("NO");
                return;
            }
        }
        System.out.print("YES");
    }
}