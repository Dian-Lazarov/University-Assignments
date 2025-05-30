package oop_ex3;

public class Student extends Person {
	private String university;
	private String specialty;

	// constructor
	public Student(String name, int age, String university, String specialty) {
		super(name, age);
		this.university = university;
		this.specialty = specialty;
	}
	
	// method
	void personInfo () {
		super.personInfo();
		System.out.println("�����������: " + university);
		System.out.println("�����������: " + specialty);
	}
	
	public void print() {
		super.print(); // using the interface method
		System.out.println("�����������: " + university);
		System.out.println("�����������: " + specialty);
	}
}