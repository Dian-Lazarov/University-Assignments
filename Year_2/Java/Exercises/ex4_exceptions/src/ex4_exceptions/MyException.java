package ex4_exceptions;

public class MyException extends Exception {

	public MyException() {
		super("Деление на нула не е позволено.");
	}

	public MyException(String s) {
		super(s);
	}
}