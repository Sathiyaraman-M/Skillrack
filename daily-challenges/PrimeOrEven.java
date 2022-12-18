import java.util.*;
public class Hello {
    static boolean IsPrime(int N) {
        if(N % 2 == 0) return true;
        for(int i = 2; i < N / 2; i++) {
            if(N % i == 0)
                return false;
        }
        return true;
    }
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var N = sc.nextInt();
        System.out.print(IsPrime(N) ? "valid" : "invalid");
    }
}