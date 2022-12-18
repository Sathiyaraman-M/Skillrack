import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
        var input = sc.nextLine().trim();
        var len = input.length();
        var even = Integer.parseInt(String.valueOf(input.charAt(0))) % 2 == 0;
        System.out.print(input.charAt(0));
        for(int i = 1; i < len; i++) {
            var status = Integer.parseInt(String.valueOf(input.charAt(i))) % 2 == 0;
            if(status != even) 
                break;
            System.out.print(input.charAt(i));
        }
    }
}