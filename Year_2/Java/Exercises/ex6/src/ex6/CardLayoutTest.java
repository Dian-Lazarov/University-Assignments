package ex6;

//CardLayout
import java.awt.*;
import java.awt.event.*;

class CardLayoutTest extends Frame {
CardLayout cardLayout = new CardLayout();
Panel p1 = new Panel(cardLayout);
Panel p2 = new Panel(new GridLayout(1, 0));
public CardLayoutTest() {
		super("CardLayout Example");
		p1.add(new Label("First" , Label.CENTER), "First");
		p1.add(new Label("Second", Label.CENTER), "Second");
		p1.add(new Label("Third" , Label.CENTER), "Third");
		p1.add(new Label("Show" , Label.CENTER), "Show");
		p1.add(new Label("Last" , Label.CENTER), "Last");
		add(p1, BorderLayout.CENTER);

		AL al = new AL();
		Button button;
		p2.add(button =new Button("First"));
		button.addActionListener(al);
		p2.add(button = new Button("Next"));
		button.addActionListener(al);
		p2.add(button = new Button("Prev"));
		button.addActionListener(al);
		p2.add(button = new Button("Last"));
		button.addActionListener(al);
		p2.add(button = new Button("Show"));
		button.addActionListener(al);
		add(p2, BorderLayout.SOUTH);
		pack();
		setVisible(true);
}
class AL implements ActionListener {
	public void actionPerformed(ActionEvent evt) {
		String cmd = evt.getActionCommand();
		if ("First".equals(cmd)) {
			cardLayout.first(p1);
		} else if ("Prev".equals(cmd)) {
			cardLayout.previous(p1);
		} else if ("Next".equals(cmd)) {
			cardLayout.next(p1);
		} else if ("Last".equals(cmd)) {
			cardLayout.last(p1);
		} else if ("Show".equals(cmd)) {
			cardLayout.show(p1, cmd);
		}
	}
}
public static void main(String args[]) {
	CardLayoutTest c = new CardLayoutTest();
	c.addWindowListener(
			new WindowAdapter() {
				public void windowClosing(WindowEvent e) {
					System.exit(0);
				}
			});
}
}
