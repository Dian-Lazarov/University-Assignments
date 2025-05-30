package ex4;

public class StringParse {
	public static void main(String[] args) {
		try {
			String toInt = "12,,,34";
			int convertInt = Integer.parseInt(toInt);
			System.out.println(convertInt);

		} catch (NumberFormatException e) {
			e.printStackTrace(); // displays the error message
			System.out.println("End of program.\n");
		}

		try {
			String arr[] = new String[2];
			arr[0] = "1234";
			arr[1] = "56,,,78";
			for (int i = 0; i <= 2; i++) {
				int convertArr = Integer.parseInt(arr[i]);
				System.out.println(convertArr);
			}
		} catch (NumberFormatException e) {
			e.printStackTrace();
			System.out.println("End of program.");
		}
	}
}