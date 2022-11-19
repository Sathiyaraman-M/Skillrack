import java.util.*;
public class Hello {

    public static void main(String[] args) {
        
	    int N = new Scanner(System.in).nextInt();
	    for(int i = N; i >= 1; i--)
	        if(N % i == 0)
                System.out.print(i + " ");
    }
}