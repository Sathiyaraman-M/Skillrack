import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new int[N];
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
        }
        var X = sc.nextInt();
        var count = 0;
        for(int i = 0; i < N; i++) {
            if(arr[i] == X) {
                count++;
            }
        }
        System.out.print(count == X ? "YES" : "NO");
    } 
}