import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new int[N];
        for(int i = 0; i < N; i++)
            arr[i] = sc.nextInt();
        for(int i = 0; i < N; i++) {
            if(arr[i] == 1) {
                for(int j = N - 1; j > i; j--) {
                    if(arr[j] == 0) {
                        arr[j] = 1;
                        arr[i] = 0;
                        break;
                    }
                }
            }
        }
        for(int i = 0; i < N; i++)
            System.out.print(arr[i] + " ");
    }
}