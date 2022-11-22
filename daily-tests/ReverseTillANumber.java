import java.util.*;
public class Main {
	public static void main(String[] args) {
		var sc = new Scanner(System.in);
		var string = sc.nextLine().trim();
		var ch = sc.next().charAt(0);
		var len = string.length();
		if(len == 1 && string.charAt(0) == ch) {
			System.out.print(string);
			return;
		}
		int index = 0;
		while(string.charAt(index) != ch && index < len) {
		    index += 1;
		}
		if(index == len - 1) {
		    System.out.print("-1");
		    return;
		}
		for(int i = index; i >= 0; i--) {
	            System.out.print(string.charAt(i));
      	}
	}
}