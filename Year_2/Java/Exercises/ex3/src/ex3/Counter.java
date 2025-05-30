package ex3;

public class Counter {
	private int br; //static (always max value)

//constructor
	public Counter() {
		br = 0;
	}

//methods
	public void increment() {
		br++;
	}

	public int getValue() {
		return br;
	}

}