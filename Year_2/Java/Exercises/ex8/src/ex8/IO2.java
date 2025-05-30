package ex8;

import java.io.*;

public class IO2 {
	public static void main(String[] args) throws Exception {
		String filename = "test.bin";

		System.out.println("Reading file " + filename);
		DataInputStream in = new DataInputStream(new BufferedInputStream(new FileInputStream(filename)));

		while (true) {
			@SuppressWarnings("deprecation")
			String s = in.readLine();
			if (s == null) {
				break;
			}
			System.out.println(s);
		}
		in.close();
	}
}