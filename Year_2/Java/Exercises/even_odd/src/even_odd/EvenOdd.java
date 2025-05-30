package even_odd;

import java.util.Scanner; // необходимо за първи метод
import java.io.IOException; // необходимо за втори метод

public class EvenOdd {

	public static void main(String[] args) throws IOException {
		/* // първи метод
		 * Scanner numIN = new Scanner(System.in);
		 * System.out.println("Въведете число:");
		 * 
		 * if (numIN.nextInt() % 2 == 0) { // остатък 0 при деление на 2
		 * System.out.println("Въведеното число е четно."); }
		 * 
		 * else { System.out.println("Въведеното число е нечетно."); } numIN.close();
		 */

		// втори метод (само за числата от 0 до 9)
		int numREAD;;
		System.out.println("Въведете число:");
		numREAD = System.in.read();
		System.out.println("ASCII (int) = " + (int)numREAD);
		System.out.println("ASCII (float) = " + (float)numREAD);
		System.out.println("ASCII (double) = " + (double)numREAD);
		System.out.println("ASCII (char) = " + (char)numREAD);
		System.out.println("ASCII (short) = " + (short)numREAD);
		System.out.println("ASCII (long) = " + (long)numREAD);
		System.out.println("ASCII (byte) = " + (byte)numREAD);
		//System.out.println("ASCII (boolean) = " + (boolean)numREAD);

		if (numREAD % 2 == 0) {
			System.out.println("Въведеното число е четно.");
		}

		else {
			System.out.println("Въведеното число е нечетно.");
		}

		/* // трети метод
		 * int numOUT = 9;
		 * 
		 * if (numOUT % 2 == 0) { System.out.println("Числото е четно."); }
		 * 
		 * else { System.out.println("Числото е нечетно."); }
		 */
	}
}