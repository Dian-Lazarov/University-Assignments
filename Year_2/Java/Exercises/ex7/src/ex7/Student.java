package ex7;

// For a hashed collection (e.g. HashSet) to work, 

// BOTH hashCode() and equals() must be overriden *carefully*!	
// Both methods must be based on the same attribute or set of attributes.
// These two methods are defined in Object class - the root of the class tree in Java.

// For a sorted collection or map (e.g. TreeSet) to work, 
// the Comparable interface must be implemented and compareTo() overriden!
// Comparable is a standard interface, part of JDK.

public class Student {
	long fakNo;
	String name;

	public Student(long fakNo, String name) {
		this.fakNo = fakNo;
		this.name = name;
	}

	@Override
	public String toString() {
		return "‘‡Í π: " + fakNo + ", " + "»ÏÂ: " + name;
	}
}