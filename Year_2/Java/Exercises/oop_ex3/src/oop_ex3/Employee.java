package oop_ex3;

public class Employee extends Person {
	private String company;
	private float salary;

	// constructor
	public Employee(String name, int age, String company, float salary) {
		super(name, age);
		this.company = company;
		this.salary = salary;
	}

	// method
	void personInfo() {
		super.personInfo();
		System.out.println("Фирма: " + company);
		System.out.println("Заплата: " + salary + " лв.");
	}
	
	public void print() {
		super.print(); // using the interface method
		System.out.println("Фирма: " + company);
		System.out.println("Заплата: " + salary + " лв.");
	}
}