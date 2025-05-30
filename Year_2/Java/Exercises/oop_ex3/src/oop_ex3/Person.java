package oop_ex3;

public class Person extends PrintAdapter implements PrintInterface { // PrintAdapter overrides PrintInterface
	private String name; // fuck char
	private int age;
	
	// constructor
	public Person(String name, int age) {
		this.name = name; // this.name = new String(name);
		this.age = age;
	}

	// method
	void personInfo() {
		System.out.println("Име: " + name);
		System.out.println("Възраст: " + age);
	}

	// method (interface)
	public void print() {
		System.out.println("Име: " + name);
		System.out.println("Възраст: " + age);
	}

	// method (interface)
	public int someMethod() {
		return 0;
	}

	// method (interface)
	public void someOtherMethod() {
	}
}