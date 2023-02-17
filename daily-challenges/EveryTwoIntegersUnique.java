import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new int[N];
        for(int i = 0; i < N; i++)
            arr[i] = sc.nextInt();
        for(int i = 0; i < N; i += 2) {
            if(arr[i] == arr[i + 1]) {
                System.out.print("no");
                return;
            }
        }
        System.out.printf("yes");
    }
}