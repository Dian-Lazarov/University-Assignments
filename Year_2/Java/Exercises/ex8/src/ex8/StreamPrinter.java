package ex8;

import java.io.*;

public class StreamPrinter {

	public static void main(String[] args) {
		System.out.print("�������� �� ������������ 123 � Ctrl-Z, Enter �� ����: ");
		try {
			while (true) {
				int data = System.in.read();
				if (data <= 0) {
					break;
				}
				System.out.println(data);
			}
		} catch (IOException ex) {
			System.err.println("Couldn't read from System.in!");
		}
	}
}