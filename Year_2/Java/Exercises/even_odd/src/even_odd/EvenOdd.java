package even_odd;

import java.util.Scanner; // ���������� �� ����� �����
import java.io.IOException; // ���������� �� ����� �����

public class EvenOdd {

	public static void main(String[] args) throws IOException {
		/* // ����� �����
		 * Scanner numIN = new Scanner(System.in);
		 * System.out.println("�������� �����:");
		 * 
		 * if (numIN.nextInt() % 2 == 0) { // ������� 0 ��� ������� �� 2
		 * System.out.println("���������� ����� � �����."); }
		 * 
		 * else { System.out.println("���������� ����� � �������."); } numIN.close();
		 */

		// ����� ����� (���� �� ������� �� 0 �� 9)
		int numREAD;;
		System.out.println("�������� �����:");
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
			System.out.println("���������� ����� � �����.");
		}

		else {
			System.out.println("���������� ����� � �������.");
		}

		/* // ����� �����
		 * int numOUT = 9;
		 * 
		 * if (numOUT % 2 == 0) { System.out.println("������� � �����."); }
		 * 
		 * else { System.out.println("������� � �������."); }
		 */
	}
}