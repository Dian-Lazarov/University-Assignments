package ex8;

import java.io.*;

public class FileInfo {

	public static void main(String[] args) {
		String filename = "c:\\windows\\explorer.exe";
		File f = new File(filename);
		if (f.exists()) {
			System.out.println("getName: " + f.getName());
			System.out.println("getPath: " + f.getPath());
			System.out.println("getAbsolutePath: " + f.getAbsolutePath());

			System.out.println("getParent: " + f.getParent());
			if (f.canWrite())
				System.out.println(f.getName() + " is writable.");
			if (f.canRead())
				System.out.println(f.getName() + " is readable.");
			if (f.isFile()) {
				System.out.println(f.getName() + " is a file.");
			} else if (f.isDirectory()) {
				System.out.println(f.getName() + " is a directory.");
			} else {
				System.out.println("What is this?");
			}
			if (f.isAbsolute()) {
				System.out.println(f.getName() + " is an absolute path.");
			} else {
				System.out.println(f.getName() + " is not an absolute path.");
			}
			System.out.println(f.getName() + "'s size is " + f.length() + " bytes.");
		} else {
			System.out.println("I'm sorry. I can't find the file " + filename);
		}
	}
}