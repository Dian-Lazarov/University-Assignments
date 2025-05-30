package ex5;

import java.awt.*;
import java.awt.event.*;

public class GUI_AWT extends Frame {
	public GUI_AWT() {
		// Window closing event handler
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});

		// Set the frame properties
		setTitle("AWT GUI with BorderLayout");
		setSize(500, 150);
		setLayout(new BorderLayout());
		setLocationRelativeTo(null); // Centers the window

		// Panel 1: Contains two labels with GridLayout
		Panel p1 = new Panel(new GridLayout(0, 2));
		Label l1 = new Label("Поле 1");
		Label l2 = new Label("Поле 2");
		p1.add(l1);
		p1.add(l2);

		// Panel 2: Contains text box and button with GridLayout
		Panel p2 = new Panel(new GridLayout(0, 2));
		TextField t1 = new TextField();
		Button b1 = new Button("Click me");
		p2.add(t1);
		p2.add(b1);

		// Panel 3: Dropdown and radio buttons
		Panel p3 = new Panel(new FlowLayout());

		// Dropdown (Choice) with 3 options
		Choice dropdown = new Choice();
		dropdown.add("елемент 1");
		dropdown.add("елемент 2");
		dropdown.add("елемент 3");
		p3.add(dropdown);

		// Radio Buttons (Checkbox with CheckboxGroup)
		Panel radioPanel = new Panel(new FlowLayout());
		CheckboxGroup group = new CheckboxGroup();
		Checkbox radioButton1 = new Checkbox("опция 1", group, false);
		Checkbox radioButton2 = new Checkbox("опция 2", group, false);
		Checkbox radioButton3 = new Checkbox("опция 3", group, false);
		radioPanel.add(radioButton1);
		radioPanel.add(radioButton2);
		radioPanel.add(radioButton3);
		p3.add(radioPanel);

		// Add panels to the frame using BorderLayout
		add(p1, BorderLayout.NORTH); // Top panel with labels
		add(p2, BorderLayout.CENTER); // Center panel with text box and button
		add(p3, BorderLayout.SOUTH); // Bottom panel with dropdown and radio buttons
		setVisible(true);

		// Add ActionListener to the button
		b1.addActionListener(new ActionListener() {
			String selectedDropdown = new String();
		    String selectedRadio = new String();
			String textFieldContent = new String();
			
			@Override
			public void actionPerformed(ActionEvent e) {
				// Save the selected option from the dropdown
				selectedDropdown = dropdown.getSelectedItem();

				// Save the selected option from the radio button group
				Checkbox selectedCheckbox = group.getSelectedCheckbox();
				//selectedRadio = (selectedCheckbox != null) ? selectedCheckbox.getLabel() : "None";
				if (selectedCheckbox != null) {
				    selectedRadio = selectedCheckbox.getLabel();
				} else {
				    selectedRadio = "None";
				}

				// Save and clear the text field content
				textFieldContent = t1.getText();
				t1.setText(""); // Clear the text field

				// Output all strings to the console
				System.out.println("Избран елемент от падащото меню: " + selectedDropdown);
				System.out.println("Избран радио-бутон: " + selectedRadio);
				System.out.println("Съдържание на текстовото поле: " + textFieldContent);
			}
		});
	}

	public static void main(String[] args) {
		new GUI_AWT();
	}
}
