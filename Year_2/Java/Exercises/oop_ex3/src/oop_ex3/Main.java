package oop_ex3;

public class Main {

	public static void main(String[] args) {
		System.out.println("===PERSON===");
		Person pr = new Person("Диан", 20);
		pr.personInfo();
		// pr.print(); // interface method

		System.out.println("\n===STUDENT===");
		Student st = new Student("Диан", 20, "Русенски университет „Ангел Кънчев“", "КСТ");
		st.personInfo();
		// st.print(); // interface method

		System.out.println("\n===EMPLOYEE===");
		Employee em = new Employee("Диан", 20, "DidoSoft", 6900);
		em.personInfo();
		// em.print(); // interface method

		System.out.println("\n===ARRAY===");
		Person array[] = new Person[3];
		// Person array_alt[] = { pr, st, em };
		array[0] = pr;
		array[1] = st;
		array[2] = em;
		for (int i = 0; i < array.length; i++) {
			array[i].personInfo();
			// array[i].print(); // interface method
			// array_alt[i].personInfo();
		}
	}
}