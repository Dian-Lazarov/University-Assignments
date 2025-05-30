package ex5;

import java.awt.*; // if module-info.java exists, add "requires java.desktop;" inside the module body to get rid of the "not accessible" error
import java.awt.event.*;

public class MyGraphicsAWT extends Frame {

	public MyGraphicsAWT() {
		this.setTitle("test");
		setSize(500, 500); // width, height
		setLocationRelativeTo(null);

		// натискане на бутона за затваряне на прозореца
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		}); // край на кода за обработка на събитието
		setVisible(true);
	} // край на конструктора

	public void paint(Graphics g) {
		g.setColor(Color.red); // следва изчертаване на запълнен с указания цвят правоъгълник
		g.fillRect(30, 30, 200, 100); // с координати на горен ляв ъгъл 30 px по x и y, ширина – 200, височина – 100 px
		g.setColor(Color.white);
		g.drawString("Hello", 50, 50);
	}

	public static void main(String[] args) {
		new MyGraphicsAWT();
	}
}