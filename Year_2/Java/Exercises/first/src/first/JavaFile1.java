package first;

public class JavaFile1 {
	int a;
	int b;
	// int a,b;

	// constructors
	public JavaFile1(int a, int b) {
		this.a = a;
		this.b = b;
	}

	// main
	public static void main(String[] args) {
		System.out.println("Първи проект");

		JavaFile1 obj = new JavaFile1(5, 8);

		System.out.println(obj.getA() + "\n" + obj.getB());
		// obj.getA(); System.out.println(obj.a);
		System.out.println(obj.getB());
		// obj.getB(); System.out.println(obj.b);

		obj.setA(0);
		obj.setB(1);
		System.out.println(obj.getA() + " " + obj.getB());
	}

	// definitions
	public int getA() {
		return a;
	}

	public void setA(int a) {
		this.a = a;
	}

	public int getB() {
		return b;
	}

	public void setB(int b) {
		this.b = b;
	}

}