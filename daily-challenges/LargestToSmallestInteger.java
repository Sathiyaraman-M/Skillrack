import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var A = sc.nextInt();
        var B = sc.nextInt();
        var C = sc.nextInt();
        var min = (A > B ? (B > C ? C : B) : (A > C ? C : A));
        var max = (A > B ? (A > C ? A : C) : (B > C ? B : C));
        for(int i = max; i >= min; i--) {
            System.out.print(i + " ");
        }
    }
}