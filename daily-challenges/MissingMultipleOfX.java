import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var X = sc.nextInt();
        var N = sc.nextInt();
        var arr = new int[N - 1];
        for(int i = 0; i < N - 1; i++) {
            arr[i] = sc.nextInt();
        }
        int start = arr[0];
        for(int i = 0; i < N - 1; i++) {
            if(start != arr[i]) {
                System.out.print(start);
                return;
            }
            start += X;
        }
        System.out.print(start);
    }
}