import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        var arr = new int[N];
        arr[0] = sc.nextInt();
        var max = arr[0];
        for(int i = 1; i < N; i++) {
            arr[i] = sc.nextInt();
            if(max < arr[i]) 
                max = arr[i];
        }
        for(int i = 0; i < N; i++) {
            System.out.print(arr[i] + " ");
            if(arr[i] == max)
                break;
        }
    }
}