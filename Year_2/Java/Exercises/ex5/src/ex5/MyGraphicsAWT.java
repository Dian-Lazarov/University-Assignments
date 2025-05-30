package ex5;

import java.awt.*; // if module-info.java exists, add "requires java.desktop;" inside the module body to get rid of the "not accessible" error
import java.awt.event.*;

public class MyGraphicsAWT extends Frame {

	public MyGraphicsAWT() {
		this.setTitle("test");
		setSize(500, 500); // width, height
		setLocationRelativeTo(null);

		// ��������� �� ������ �� ��������� �� ���������
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		}); // ���� �� ���� �� ��������� �� ���������
		setVisible(true);
	} // ���� �� ������������

	public void paint(Graphics g) {
		g.setColor(Color.red); // ������ ����������� �� �������� � �������� ���� ������������
		g.fillRect(30, 30, 200, 100); // � ���������� �� ����� ��� ���� 30 px �� x � y, ������ � 200, �������� � 100 px
		g.setColor(Color.white);
		g.drawString("Hello", 50, 50);
	}

	public static void main(String[] args) {
		new MyGraphicsAWT();
	}
}