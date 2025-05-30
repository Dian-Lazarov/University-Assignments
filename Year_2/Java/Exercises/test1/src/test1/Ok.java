package test1;

public class Ok {
	static int attr1;

	public static int method1() {
		return 5;
	};

	public static void method2(int x) {
		System.out.println("x=" + x);
	};

	public static void main(String args[]) {
		/*
		 * attr1=5; int x=method1(); method2(x); method2(attr1);
		 */

		/*int arr[] = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		int sum = 0;
		int count = 0;

		for (int i = 0; i < 10; i++) {
			count++;
		}

		for (int i = 0; i < arr.length; i++) {
			sum += arr[i];
		}
		float avg = (float) sum / arr.length;
		float avg2 = (float) sum / count;

		System.out.println("The sum of the elements is: " + sum);
		System.out.println("The average value of the elements is: " + avg);
		System.out.println("The average value of the elements is: " + avg2);*/
		
		int arr2[][] = new int[2][2];
		arr2[0][0] = 0;
		arr2[0][1] = 1;
		arr2[1][0] = 2;
		arr2[1][1] = 3;
		int i, j;
		for (i = 0; i < arr2.length; i++) {
			for (j = 0; j < arr2[i].length; j++) {
				System.out.println(arr2[i][j] + " ");
			}
			System.out.println();
		}
		System.out.println();
	}
}