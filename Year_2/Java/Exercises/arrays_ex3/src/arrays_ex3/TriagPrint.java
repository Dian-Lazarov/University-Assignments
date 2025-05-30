package arrays_ex3;

public class TriagPrint {

	float Average(int arr[]) { // static
		float sum = 0;

		for (int i = 0; i < arr.length; i++) {
			sum = sum + arr[i];
		}
		return sum / arr.length;
	}

	public static void main(String[] args) {
		int i, j;

		// triangular two-dimensional array
		int[][] triag = new int[5][]; // define the number of rows
		for (i = 0; i < triag.length; i++) {
			triag[i] = new int[2 * i + 2]; // define columns: 2 columns in row 0, 4 columns in row 1, etc.
			for (j = 0; j < triag[i].length; j++) {
				triag[i][j] = i + j;
			}
		}
		Matrix.matrixPrint(triag);

		TriagPrint tp = new TriagPrint();
		for (i = 0; i < triag.length; i++) {
			System.out.println("Средноаритметична стойност за ред " + i + ": " + tp.Average(triag[i]));
		}
	}
}