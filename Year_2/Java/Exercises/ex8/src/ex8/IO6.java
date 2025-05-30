package ex8;

import java.io.*;
import java.util.zip.*;

public class IO6 {
	public static void main(String[] args) throws Exception {
		String filename = "C:\\Users\\Linko\\Desktop\\University\\Bachelor\\II kurs\\III semestur\\Programming Languages\\uprajneniq\\workshops_1567_bg\\IO.zip"; // If the file can not be found, specify the absolute path!

		System.out.println("Reading archive " + filename);
		ZipInputStream zips = new ZipInputStream(new FileInputStream(filename));
		BufferedReader in = new BufferedReader(new InputStreamReader(zips));
		ZipEntry ze;
		while (true) {
			ze = zips.getNextEntry();
			if (ze == null) { break; }
			System.out.println("Found file: " + ze.getName());
			while (true) {
				String s = in.readLine();
				if (s == null) { break; }
				System.out.println(s);
			}
		}
		in.close();
	}
}