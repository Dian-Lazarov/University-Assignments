package ex4_exceptions;

public class DivisionZero {

	float m1(float delimo, float delitel) throws MyException {
		if (delitel == 0) {
			throw new MyException();
		} else {
			return delimo / delitel;
		}
	}

	public static void main(String[] args) {
		try {
			DivisionZero div0 = new DivisionZero();
			float result = div0.m1(5, 0);
			System.out.println("Резултат: " + result);
		} catch (MyException e) {
			e.printStackTrace();
			// System.out.println(e.getMessage());
		}
	}
}