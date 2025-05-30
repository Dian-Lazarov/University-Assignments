package ex8;

import java.io.*;

public class IO3 {
	public static void main(String[] args) throws Exception {
		String filename = "test.bin";

		System.out.println("Reading file " + filename);
		BufferedReader in = new BufferedReader(new InputStreamReader(new FileInputStream(filename)));

		while (true) {
			String s = in.readLine();
			if (s == null)
				break;
			System.out.println(s);
		}
		in.close();
	}
}