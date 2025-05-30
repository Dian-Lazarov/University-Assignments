package ex7;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;
import java.util.*;

public class GUI extends JFrame {

	private JTextField tf_fno;
	private JTextField tf_name;
	private ArrayList<Student> students = new ArrayList<Student>(); // Attribute for the collection & initialization

	public GUI() {
		setBounds(200, 200, 320, 100);
		setResizable(false);
		setDefaultCloseOperation(EXIT_ON_CLOSE);

		setLayout(new GridLayout(0, 2));

		add(new JLabel("Fac. No:"));
		add(tf_fno = new JTextField(10));

		add(new JLabel("Name:"));
		add(tf_name = new JTextField(10));

		JButton bn_add = new JButton("Add");
		add(bn_add);
		bn_add.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				String nm = tf_name.getText();
				String sfno = tf_fno.getText();
				long fno = 0;
				try {
					fno = Long.parseLong(sfno);
				} catch (NumberFormatException x) {
				}
				if (fno == 0) {
					JOptionPane.showMessageDialog(null, "Bad Fac. No.", "Error", JOptionPane.ERROR_MESSAGE);
				} else {
					onAdd(fno, nm);
				}
			}
		});

		JButton bn_lst = new JButton("Show all");
		add(bn_lst);
		bn_lst.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				onShowAll();
			}
		});

		setVisible(true);
	}

	// Method to add a student to the collection
	public void onAdd(long fakNo, String name) {
		Student student = new Student(fakNo, name); // Create a new Student object
		students.add(student); // Add the student to the ArrayList
		System.out.println("Student added: " + student.toString());
		tf_fno.setText(""); // Clear the input fields
		tf_name.setText("");
	}

	// Method to show all students in the console
	public void onShowAll() {
		if (students.isEmpty()) {
			System.out.println("No students to show.");
			return;
		}

		System.out.println("List of students:");
		/*for (int i = 0; i < students.size(); i++) { // Standard for loop
			Student stud = students.get(i);
			System.out.println(stud.toString());
		//  System.out.println((i + 1) + ". " + students.get(i).toString());
		}*/
		

		/*for (Student stud : students) { // Enhanced for loop
			System.out.println(stud.toString());
		}*/
		
		
		/*Student studArr[] = new Student[students.size()]; // toArray()
		students.toArray(studArr);
		for (int i = 0; i < studArr.length; i++) {
			Student stud=studArr[i];
			System.out.println(stud.toString());
		}*/
		
		
        /*Iterator<Student> itr = students.iterator(); // Iterator

        // Iterate through the collection using the iterator
        while (itr.hasNext()) {
            Student stud = itr.next();
            System.out.println(stud.toString());
        }*/
		
		students.forEach(stud->System.out.println(stud.toString())); // Lambda expression (forEach)
	}

	public static void main(String[] args) {
		new GUI();
	}
}
