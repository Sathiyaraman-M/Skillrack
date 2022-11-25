import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
		var input1 = sc.nextLine().trim();
		var input2 = sc.nextLine().trim();
		var n1 = sc.nextInt();
		var n2 = sc.nextInt();
		var output1 = input1.substring(0, n1) 
		                + input2.substring(input2.length() - n2);
		var output2 = input2.substring(0, input2.length() - n2) 
		                + input1.substring(n1);
		System.out.println(output1);
		System.out.print(output2);
    }
}