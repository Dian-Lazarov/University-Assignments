package ex5;

import java.awt.*;
import java.awt.event.*;

public class SimpleGraphics extends Frame {

	public SimpleGraphics() {
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});
		setTitle("Demo");
		setSize(500, 500);
		setLocationRelativeTo(null); // or setLocation(30, 40);
		setBackground(Color.yellow);
		setVisible(true);
	}

	@Override
	public void paint(Graphics g) {
		g.setColor(Color.white);
		g.fillRect(40, 40, 200, 40);

		g.setColor(Color.green);
		g.fillRect(40, 80, 200, 40);

		g.setColor(Color.red);
		g.fillRect(40, 120, 200, 40);
	}

	public static void main(String[] args) {
		new SimpleGraphics();
	}
}