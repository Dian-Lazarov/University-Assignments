package arrays_ex3;

public class Matrix {

	public static void matrixPrint(int[][] mat) {
		int i, j;
		
		for (i = 0; i < mat.length; i++) {
			for (j = 0; j < mat[i].length; j++) {
				System.out.print(mat[i][j] + " ");
			}
			System.out.println();
		}
		System.out.println();

	}

}