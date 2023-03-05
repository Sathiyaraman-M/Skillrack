import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var A = sc.nextLong();
        var B = sc.nextLong();
        sc.close();
        var temp = A % 10;
        A = A - temp + B % 10;
        B = B - B % 10 + temp;
        System.out.print(A * B);
    }
}