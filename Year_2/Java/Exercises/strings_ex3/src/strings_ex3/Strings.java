package strings_ex3;

public class Strings {
	public static void main(String[] args) {
		String s1 = "Hello", s2 = "World";
		String s3 = s1 + " " + s2;
		StringBuffer sb1 = new StringBuffer(s3); // sb1.append(s3);
		sb1.reverse();
		System.out.println(s3);
		System.out.println(sb1);
		System.out.println("\n");

		String s4 = new String("Hello");
		String s5 = s4.concat(" " + "World");
		System.out.println(s5);

		StringBuffer sb2 = new StringBuffer("Hello");
		sb2.append(" " + "World");
		sb2.reverse();
		System.out.println(sb2);
	}
}