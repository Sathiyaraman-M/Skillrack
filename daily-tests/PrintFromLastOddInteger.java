import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var index = 0;
        var arr = new int[N];
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
            if(arr[i] % 2 != 0) {
                index = i;
            }
        }
        for(int i = index; i >= 0; i--) {
            System.out.print(arr[i] + " ");
        }
    }
}