package ex8;

import java.io.RandomAccessFile;
import java.io.IOException;
//import java.nio.charset.StandardCharsets;

public class FileRandom {

	// Define the string constant
	private static final String TEXT = "I love Java. Обичам Java. ジャワが大好きです.";

	public static void main(String[] args) {
		// File name for the random access file
		String fileName = "random_access_file.txt";

		try {
			// Create a RandomAccessFile in "rw" (read-write) mode
			RandomAccessFile randomAccessFile = new RandomAccessFile(fileName, "rw");

			// Write the string to the file
			randomAccessFile.write(TEXT.getBytes());
			System.out.println("String written to file: " + TEXT);

			// Seek to the beginning of the file and read the first 12 bytes
			randomAccessFile.seek(0);
			byte[] first12Bytes = new byte[12];
			randomAccessFile.read(first12Bytes);
			System.out.println("First 12 bytes: " + new String(first12Bytes));

			// Seek to byte 12 and read the next 18 bytes
			randomAccessFile.seek(12);
			byte[] next18Bytes = new byte[18];
			randomAccessFile.read(next18Bytes);
			System.out.println("Next 18 bytes: " + new String(next18Bytes));

			// Seek to byte 30 and read the next 28 bytes
			randomAccessFile.seek(30);
			byte[] next28Bytes = new byte[28];
			int bytesRead = randomAccessFile.read(next28Bytes);
			if (bytesRead > 0) {
				System.out.println("Next 28 bytes: " + new String(next28Bytes, 0, bytesRead));
			} else {
				System.out.println("No bytes available to read at position 30.");
			}

			// Close the RandomAccessFile
			randomAccessFile.close();

		} catch (IOException e) {
			System.err.println("Error occurred: " + e.getMessage());
		}
	}
}