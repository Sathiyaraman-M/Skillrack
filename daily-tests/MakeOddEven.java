import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new int[N];
        var odd = 0;
        var even = 0;
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
            if(arr[i] % 2 == 0) {
                even++;
            } else {
                odd++;
            }
        }
        if(odd > even) {
            for(int i = 0; i < N; i++) {
                if(arr[i] % 2 != 0) {
                    arr[i]++;
                }
            }
        } else if(odd < even) {
            for(int i = 0; i < N; i++) {
                if(arr[i] % 2 == 0) {
                    arr[i]--;
                }
            }
        } else {
            for(int i = 0; i < N; i++) {
                if(arr[i] % 2 == 0) {
                    arr[i]--;
                } else {
                    arr[i]++;
                }
            }
        }
        for(int i = 0; i < N; i++) {
            System.out.print(arr[i] + " ");
        }
    }
}