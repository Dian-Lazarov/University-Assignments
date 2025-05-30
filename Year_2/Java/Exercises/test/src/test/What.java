package test;

public class What extends Thread {
	int count;
	public static void main(String args[]) throws Exception {
		/*
		 * System.out.println("Hello, world! | Здравей, свят!");
		 * 
		 * int a = 4, b = 2, c; do { if (b == 0)
		 * System.out.println("Please enter non-zero for b!"); } while (b == 0); c = a /
		 * b; System.out.println("a=" + a + "b=" + b + "c= " + c);
		 */

		/*int i[] = { 0, 1 };
		try {
			i[2] = i[0] + i[1];
		} catch (ArrayIndexOutOfBoundsException e1) {
			System.out.println("1");
		} catch (Exception e2) {
			System.out.println("2");
		} finally {
			System.out.println("3");
		}
		System.out.println("4");*/
		
		Thread t1 = new What();
		Thread t2 = new What();
		//Thread t3 = new What();
		t1.start();
		t2.start();
		//t3.start();
	}
	public void run(){
		for(int i=0;i<3;i++) System.out.print(count++ +" ");
		}
}