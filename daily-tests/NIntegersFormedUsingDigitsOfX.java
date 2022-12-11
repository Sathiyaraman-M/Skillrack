import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new int[N];
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
        }
        var X = sc.nextLong();
        var counter = new int[10];
        while(X > 0) {
            var digit = (int)(X % 10);
            counter[digit]++;
            X /= 10;
        }
        var success = true;
        for(var i: arr) {
            if(counter[i] == 0) {
                success = false;
                break;
            }
        }
        System.out.print(success ? "YES" : "NO");
    }
}