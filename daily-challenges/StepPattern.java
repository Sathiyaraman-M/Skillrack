import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var string = sc.nextLine().trim();
        var len = string.length();
        var N = sc.nextInt();
        var c = 0;
        var incMode = true;
        for(int i = 0; i < len; i++) {
            for(int j = 0; j < c; j++) {
                System.out.print('*');
            }
            c += incMode ? 1 : -1;
            System.out.println(string.charAt(i));
            if(c == N - 1 || c == 0) {
                incMode = !incMode;
            }
        }
    }
}