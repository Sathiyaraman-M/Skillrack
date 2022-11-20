import java.util.*;
public class Hello {
    public static void main(String[] args) {
        var sc = new Scanner(System.in);
		int N = sc.nextInt();
		var list = new ArrayList<Long>();
		for(int i = 0; i < N; i++)
		    list.add(sc.nextLong());
		Collections.sort(list);
		System.out.print((long)list.toArray()[N - 2] * (long)list.toArray()[N - 1]);
	}
}