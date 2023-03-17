import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var str = new Scanner(System.in).nextLine().trim();
        var len = str.length();
        var start = -1;
        var end = -1;
        var vowels = "aeiouAEIOU";
        for(int i = 0; i < len; i++) {
            if(!vowels.contains(Character.toString(str.charAt(i)))) {
                if(start == -1) {
                    start = i;
                }
                end = i;
            }
        }
        if(start != -1 && end != -1) {
            System.out.print(str.substring(0,start) + new StringBuilder(str.substring(start, end + 1)).reverse().toString() + str.substring(end + 1));
        } else {
            System.out.print(str);
        }
    }
}