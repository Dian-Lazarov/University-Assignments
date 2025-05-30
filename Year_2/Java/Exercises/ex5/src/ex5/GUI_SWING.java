package ex5;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;

public class GUI_SWING extends JFrame {

	public GUI_SWING() {
		// Set the frame properties
		setTitle("Swing GUI with BorderLayout");
		setSize(500, 150);
		setLayout(new BorderLayout());
		setLocationRelativeTo(null); // Centers the window
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		// Panel 1: Contains two labels with GridLayout
		JPanel p1 = new JPanel(new GridLayout(0, 2));
		JLabel l1 = new JLabel("Field 1");
		JLabel l2 = new JLabel("Field 2");
		p1.add(l1);
		p1.add(l2);

		// Panel 2: Contains text box and button with GridLayout
		JPanel p2 = new JPanel(new GridLayout(0, 2));
		JTextField t1 = new JTextField();
		JButton b1 = new JButton("Click me");
		p2.add(t1);
		p2.add(b1);

		// Panel 3: Dropdown and radio buttons
		JPanel p3 = new JPanel(new FlowLayout());

		// Dropdown (JComboBox) with 3 options
		JComboBox<String> dropdown = new JComboBox<>();
		dropdown.addItem("Element 1");
		dropdown.addItem("Element 2");
		dropdown.addItem("Element 3");
		p3.add(dropdown);

		// Radio Buttons (JRadioButton with ButtonGroup)
		JPanel radioPanel = new JPanel(new FlowLayout());
		ButtonGroup group = new ButtonGroup();
		JRadioButton radioButton1 = new JRadioButton("Option 1");
		JRadioButton radioButton2 = new JRadioButton("Option 2");
		JRadioButton radioButton3 = new JRadioButton("Option 3");
		group.add(radioButton1);
		group.add(radioButton2);
		group.add(radioButton3);
		radioPanel.add(radioButton1);
		radioPanel.add(radioButton2);
		radioPanel.add(radioButton3);
		p3.add(radioPanel);

		// Add panels to the frame using BorderLayout
		add(p1, BorderLayout.NORTH); // Top panel with labels
		add(p2, BorderLayout.CENTER); // Center panel with text box and button
		add(p3, BorderLayout.SOUTH); // Bottom panel with dropdown and radio buttons

		setVisible(true);
	}

	public static void main(String[] args) {
		new GUI_SWING();
	}
}