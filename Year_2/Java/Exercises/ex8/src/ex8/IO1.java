package ex8;

import java.io.*;

public class IO1 {
	public static void main(String args[]) throws IOException {
		String filename = "test.bin";

		DataOutputStream out = new DataOutputStream(new FileOutputStream(filename));
		out.writeInt(1234);
		out.writeDouble(3.14);
		out.writeBytes("Hello ­  здравей\n");
		out.writeUTF("Hello ­  здравей ");
		out.writeBoolean(true);
		out.close();

		DataInputStream in = new DataInputStream(new FileInputStream(filename));
		int i = in.readInt();
		System.out.println("int=" + i);
		double x = in.readDouble();
		System.out.println("double=" + x);

		@SuppressWarnings("deprecation")
		String s1 = in.readLine();
		System.out.println("String1=" + s1);

		String s2 = in.readUTF();
		System.out.println("String2=" + s2);
		boolean b = in.readBoolean();
		System.out.println("boolean=" + b);
		in.close();
	}
}