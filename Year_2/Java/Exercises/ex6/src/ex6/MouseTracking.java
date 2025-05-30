package ex6;

import java.awt.*;
import java.awt.event.*;

public class MouseTracking extends Frame {

	private int mouseX = 0;
	private int mouseY = 0;

	public MouseTracking() {
		// Add a WindowListener to close the program when the window is closed
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});

		// Set up the window properties
		setTitle("Mouse Position Tracker");
		setSize(500, 500);
		setLocationRelativeTo(null);
		setVisible(true);

		// Register MouseMotionListener for detecting mouse movements
		addMouseMotionListener(new MouseMotionListener() {
			@Override
			public void mouseMoved(MouseEvent m) {
				// Get the current mouse coordinates
				mouseX = m.getX();
				mouseY = m.getY();

				// Print coordinates to the console
				System.out.println("Mouse Position: X = " + mouseX + ", Y = " + mouseY);

				// Repaint to update the displayed coordinates in the window
				repaint();
			}

			@Override
			public void mouseDragged(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
		});
	}

	@Override
	public void paint(Graphics g) {
		// Display the mouse coordinates in the window
		g.drawString("Mouse Position: X = " + mouseX + ", Y = " + mouseY, mouseX, mouseY);
	}

	public static void main(String[] args) {
		new MouseTracking();
	}
}
