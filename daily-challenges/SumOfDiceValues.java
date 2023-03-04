import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var loop = true;
        var sum = 0;
        while(loop) {
            var A = sc.nextInt();
            var B = sc.nextInt();
            sum += A + B;
            if(A != B) {
                System.out.print(sum);
                return;
            }
        }
    }
}