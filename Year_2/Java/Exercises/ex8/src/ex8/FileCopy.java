package ex8;

import java.io.*;

public class FileCopy {
	public static void main(String[] args) throws Exception, IOException {
		// Define the source and destination file paths
		String source = "source.txt";
		String destination = "destination.txt";

		// Use try-with-resources to automatically close streams
		try (
				// Create input stream to read the file
				FileInputStream FIS = new FileInputStream(source);
				BufferedInputStream BIS = new BufferedInputStream(FIS);

				// Create output stream to write to the file
				FileOutputStream FOS = new FileOutputStream(destination);
				BufferedOutputStream BOS = new BufferedOutputStream(FOS)) {
			
			// Timer to measure the file copy time
			long startTime = System.currentTimeMillis();
			
			// Buffer to hold data during copying
			byte[] buf = new byte[1024];
			int bytesRead;

			// Read from source and write to destination
			while ((bytesRead = BIS.read(buf)) != -1) {
				BOS.write(buf, 0, bytesRead);
			}
			// Flush the output stream to ensure all data is written
			BOS.flush();
			
			// Stop the timer and calculate the elapsed time
			long endTime = System.currentTimeMillis();
			long elapsedTime = endTime - startTime;

			System.out.println("File copied successfully from " + source + " to " + destination);
			System.out.println("Time taken to copy the file: " + elapsedTime + " millisecond(s)");

		} catch (FileNotFoundException e) {
			System.err.println("Error: Source file not found - " + source);
		} catch (IOException e) {
			System.err.println("Error occurred during file copy: " + e.getMessage());
		}
	}
}